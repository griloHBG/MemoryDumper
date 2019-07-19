using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Globalization;
using System.IO;
using System.Threading;

namespace MemoryDumper
{
    public partial class Form1 : Form
    {
        //permissão especial
        const int PROCESS_QUERY_INFORMATION = 0x0400;
        const int MEM_COMMIT = 0x00001000;
        const int PAGE_READWRITE = 0x04;
        const int PROCESS_WM_READ = 0x0010;
        const int PROCESS_VM_WRITE = 0x0020;
        const int PROCESS_VM_OPERATION = 0x0008;

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess,
               bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(int hProcess, Int64 lpBaseAddress,
          byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);

        /*[DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ReadProcessMemory(IntPtr hProcess, Int64 lpBaseAddress,
            out byte[] lpBuffer, long dwSize, out int lpNumberOfBytesRead);
            */
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, Int64 lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        static extern uint GetLastError();

        double[] resultado;
        double max = Double.NegativeInfinity;
        double min = Double.PositiveInfinity;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            Process process = Process.GetProcessesByName(txtNomeProcesso.Text)[0];
            IntPtr processHandle = OpenProcess(PROCESS_QUERY_INFORMATION | PROCESS_WM_READ | PROCESS_VM_OPERATION | PROCESS_QUERY_INFORMATION | PROCESS_VM_WRITE, false, process.Id);
            
            int bytesRead = 0;
            int tamanho = 0;

            if(chkMatriz.Checked)
            {
                tamanho = Decimal.ToInt32(numLinhas.Value * numColunas.Value);
            }
            else
            {
                tamanho = Decimal.ToInt32(numExtensao.Value);
            }
            byte[] buffer = new byte[sizeof(double) * tamanho];

            bool resp;

            try
            {
                //ReadProcessMemory(processHandle, Int64.Parse(txtEndereco.Text.Substring(2), NumberStyles.HexNumber), out buffer, buffer.Length, out bytesRead);
                //resp = ReadProcessMemory((int)process.Handle, Int64.Parse(txtEndereco.Text.Substring(2), NumberStyles.HexNumber), out buffer, buffer.Length, out bytesRead);
                //resp = ReadProcessMemory((int)process.Handle, Int64.Parse(txtEndereco.Text.Substring(2), NumberStyles.HexNumber), buffer, buffer.Length, ref bytesRead);
                resp = ReadProcessMemory((int)processHandle, Int64.Parse(txtEndereco.Text.Substring(2), NumberStyles.HexNumber), buffer, buffer.Length, ref bytesRead);
                //txtMemoria.Text = GetLastError().ToString();

                resultado = new double[tamanho];

                txtMemoria.Text = "";

                for (int i = 0; i < tamanho; i++)
                {
                    switch(cboTamanho.SelectedIndex)
                    {
                        case 0:     //1 byte
                            resultado[i] = (int)buffer[i];
                            break;

                        case 1:     //2 bytes
                            resultado[i] = BitConverter.ToInt16(buffer, i * sizeof(Int16));
                            break;

                        case 2:     //4 bytes
                            resultado[i] = BitConverter.ToInt32(buffer, i * sizeof(Int32));
                            break;

                        case 3:     //8 bytes
                            resultado[i] = BitConverter.ToDouble(buffer, i * sizeof(double));
                            break;

                    }

                    txtMemoria.Text += resultado[i].ToString() + "\r\n";
                }

                if(chkMatriz.Checked)
                {
                    max = Double.NegativeInfinity;
                    min = Double.PositiveInfinity;

                    dgvMemoria.Rows.Clear();
                    dgvMemoria.Columns.Clear();
                    dgvMemoria.Refresh();

                    object[] auxRow = new object[Decimal.ToInt32(numColunas.Value)];
                    for (int i = 0; i < numColunas.Value; i++)
                    {
                        dgvMemoria.Columns.Add(i.ToString(), i.ToString());
                    }
                    for (int r = 0; r < numLinhas.Value; r++)
                    {
                        for (int c = 0; c < numColunas.Value; c++)
                        {
                            auxRow[c] = resultado[Decimal.ToInt32(numLinhas.Value) * c + r];
                            max = Math.Max(max, (double)auxRow[c]);
                            min = Math.Min(min, (double)auxRow[c]);
                        }
                        
                        dgvMemoria.Rows.Add(auxRow);
                    }

                    int vermelho;

                    foreach (DataGridViewRow row in dgvMemoria.Rows)
                    {
                        row.HeaderCell.Value = row.Index.ToString();

                        foreach (DataGridViewTextBoxCell cell in row.Cells)
                        {
                            vermelho = (int)(255 * ((double)dgvMemoria.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value - min) / (max - min));
                            cell.Style.BackColor = Color.FromArgb(vermelho , 0 , 255 - vermelho);
                        }
                    }
                    
                }
                
            }
            catch (Exception ex)
            {
                txtMemoria.Text = ex.ToString();
            }
        }

        private void txtEndereco_MouseClick(object sender, MouseEventArgs e)
        {
            txtEndereco.SelectAll();
        }

        private void numExtensao_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLer_Click(this, new EventArgs());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNomeProcesso.Focus();
            txtNomeProcesso.SelectAll();

            dgvMemoria.ForeColor = Color.White;
        }

        private void txtArquivoTexto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar_Click(this, new EventArgs());
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            File.WriteAllLines(txtArquivoTexto.Text, resultado.Select(d => d.ToString()).ToArray());
        }

        private void txtMemoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab.Name == "Tabela")
            {
                chkTranspor.Visible = true;
            }
            else
            {
                chkTranspor.Visible = false;
            }
        }

        private void chkMatriz_CheckedChanged(object sender, EventArgs e)
        {
            if(chkMatriz.Checked)
            {
                lblExtensao.Enabled = false;
                numExtensao.Enabled = false;
                lblLinhas.Enabled = true;
                lblColunas.Enabled = true;
                numLinhas.Enabled = true;
                numColunas.Enabled = true;

            }
            else
            {
                lblExtensao.Enabled = true;
                numExtensao.Enabled = true;
                lblLinhas.Enabled = false;
                lblColunas.Enabled = false;
                numLinhas.Enabled = false;
                numColunas.Enabled = false;
            }
        }

        private void dgvMemoria_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.FillWeight = 10;
        }

        private void dgvMemoria_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //int vermelho = (int)(255 * ((double)dgvMemoria.Rows[e.RowIndex].Cells[e.ColumnIndex].Value - min) / (max - min));
            //e.CellStyle.BackColor = Color.FromArgb(vermelho, 0, 255 - vermelho);
        }

        private void dgvMemoria_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvMemoria.Rows[dgvMemoria.Rows.Count - 1].HeaderCell.Value = dgvMemoria.Rows.Count - 1;
        }

        private void chkTranspor_CheckedChanged(object sender, EventArgs e)
        {
            if(chkMatriz.Checked)
            {
                dgvMemoria.DataSource = null;
                dgvMemoria.Rows.Clear();
                dgvMemoria.Refresh();

                if (chkTranspor.Checked)
                {

                    dgvMemoria.Rows.Clear();
                    dgvMemoria.Columns.Clear();
                    dgvMemoria.Refresh();

                    object[] auxRow = new object[Decimal.ToInt32(numLinhas.Value)];

                    for (int i = 0; i < numLinhas.Value; i++)
                    {
                        dgvMemoria.Columns.Add(i.ToString(), i.ToString());
                    }
                    for (int c = 0; c < numColunas.Value; c++)
                    {
                        for (int r = 0; r < numLinhas.Value; r++)
                        {
                            auxRow[r] = resultado[r + c*Decimal.ToInt32(numLinhas.Value)];
                        }

                        dgvMemoria.Rows.Add(auxRow);
                    }

                    foreach (DataGridViewRow row in dgvMemoria.Rows)
                    {
                        row.HeaderCell.Value = row.Index.ToString();
                    }

                    int vermelho;

                    foreach (DataGridViewRow row in dgvMemoria.Rows)
                    {
                        row.HeaderCell.Value = row.Index.ToString();

                        foreach (DataGridViewTextBoxCell cell in row.Cells)
                        {
                            vermelho = (int)(255 * ((double)dgvMemoria.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value - min) / (max - min));
                            cell.Style.BackColor = Color.FromArgb(vermelho, 0, 255 - vermelho);
                        }
                    }
                }
                else
                {
                    dgvMemoria.Rows.Clear();
                    dgvMemoria.Columns.Clear();
                    dgvMemoria.Refresh();

                    object[] auxRow = new object[Decimal.ToInt32(numColunas.Value)];
                    for (int i = 0; i < numColunas.Value; i++)
                    {
                        dgvMemoria.Columns.Add(i.ToString(), i.ToString());
                    }
                    for (int r = 0; r < numLinhas.Value; r++)
                    {
                        for (int c = 0; c < numColunas.Value; c++)
                        {
                            auxRow[c] = resultado[Decimal.ToInt32(numLinhas.Value) * c + r];
                        }

                        dgvMemoria.Rows.Add(auxRow);
                    }

                    foreach (DataGridViewRow row in dgvMemoria.Rows)
                    {
                        row.HeaderCell.Value = row.Index.ToString();
                    }

                    int vermelho;

                    foreach (DataGridViewRow row in dgvMemoria.Rows)
                    {
                        row.HeaderCell.Value = row.Index.ToString();

                        foreach (DataGridViewTextBoxCell cell in row.Cells)
                        {
                            vermelho = (int)(255 * ((double)dgvMemoria.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value - min) / (max - min));
                            cell.Style.BackColor = Color.FromArgb(vermelho, 0, 255 - vermelho);
                        }
                    }
                }
            }
        }
    }
}
