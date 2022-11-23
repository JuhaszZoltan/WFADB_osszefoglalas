using Microsoft.Data.SqlClient;
using WFADB_osszefoglalas.Properties;

namespace WFADB_osszefoglalas
{
    public partial class FrmMain : Form
    {
        private int selID = -1;

        public FrmMain() => InitializeComponent();

        private void GetAllData(bool nagykoru)
        {
            selID = -1;
            string? whereStm = nagykoru
                ? "WHERE YEAR(GETDATE()) - YEAR(szul) >= 18"
                : null;

            dgv.Rows.Clear();
            using SqlConnection conn = new(Resources.ConnectionString);
            conn.Open();
            SqlCommand cmd = new(
                cmdText: $"SELECT * FROM emberek {whereStm};",
                connection: conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dgv.Rows.Add(
                    rdr["id"],
                    rdr[1],
                    rdr.GetBoolean(2) ? "férfi" : "nõ",
                    rdr.GetDateTime(3).ToString("yyyy. MMMM dd."));
            }

            dgv.ClearSelection();
            tbNev.Text = null;
            tbNevMOD.Text = null;
            rbNO.Checked = true;
            rbNoMOD.Checked = true;
            dtpSzul.Value = DateTime.Now;
            dtpSzulMOD.Value = DateTime.Now;
        }

        private void FrmMain_Load(object sender, EventArgs e) => GetAllData(false);
        private void cb_CheckedChanged(object sender, EventArgs e) => GetAllData(cb.Checked);

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string nev = tbNev.Text;
            string nem = rbFF.Checked ? "1" : "0";
            string szul = dtpSzul.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(nev))
                MessageBox.Show(
                    caption: "HIBA!!4!44!négy",
                    text: "Töltsd ki a nevet b+!",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
            else
            {
                using SqlConnection conn = new(Resources.ConnectionString);
                conn.Open();
                SqlCommand cmd = new(
                    cmdText:
                        "INSERT INTO emberek VALUES " +
                        $"('{nev}', {nem}, '{szul}');",
                    connection: conn);
                SqlDataAdapter adptr = new()
                {
                    InsertCommand = cmd
                };
                adptr.InsertCommand.ExecuteNonQuery();
                GetAllData(cb.Checked);
            }           
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNevMOD.Text = dgv[1, e.RowIndex].Value.ToString();
            rbFfMOD.Checked = dgv[2, e.RowIndex].Value.ToString() == "férfi";
            rbNoMOD.Checked = dgv[2, e.RowIndex].Value.ToString() == "nõ";
            dtpSzulMOD.Value = DateTime.Parse(dgv[3, e.RowIndex].Value.ToString());
            selID = (int)dgv[0, e.RowIndex].Value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNevMOD.Text))
                MessageBox.Show(
                    caption: "HIBA!!4!44!négy",
                    text: "Töltsd ki a nevet b+!",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
            else
            {
                using SqlConnection conn = new(Resources.ConnectionString);
                conn.Open();
                SqlCommand cmd = new(
                    cmdText:
                        "UPDATE emberek SET " +
                        $"nev = '{tbNevMOD.Text}', " +
                        $"nem = {(rbFfMOD.Checked ? 1 : 0)}, " +
                        $"szul = '{dtpSzulMOD.Value.ToString("yyyy-MM-dd")}' " +
                        $"WHERE id = {selID};",
                    connection: conn);
                SqlDataAdapter adptr = new()
                {
                    UpdateCommand = cmd
                };
                adptr.UpdateCommand.ExecuteNonQuery();
                GetAllData(cb.Checked);
            }
        }
    }
}