using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CLsChat
{
    public partial class FrmMain : Form
    {
        private int userId;
        private string username;
        private string connectionString = "Server=DESKTOP-HTQKDP7;Database=CLsChatDB;Integrated Security=True;";

        public FrmMain(int userId, string username)
        {
            InitializeComponent();
            this.userId = userId;
            this.username = username;

            LoadMessages();
            btnSendMessage.Click += BtnSendMessage_Click;
            btnRefreshInbox.Click += BtnRefreshInbox_Click;
        }

        private void LoadMessages()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Subject, Body, DateSent FROM Messages WHERE RecipientID = @userId";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@userId", userId);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewInbox.DataSource = dt;
            }
        }

        private void BtnSendMessage_Click(object sender, EventArgs e)
        {
            string subject = txtSubject.Text.Trim();
            string body = txtMessage.Text.Trim();

            if (string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(body))
            {
                MessageBox.Show("Subject and Message cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Messages (SenderID, RecipientID, Subject, Body, DateSent) VALUES (@senderId, @recipientId, @subject, @body, GETDATE())";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@senderId", userId);
                cmd.Parameters.AddWithValue("@recipientId", 1);
                cmd.Parameters.AddWithValue("@subject", subject);
                cmd.Parameters.AddWithValue("@body", body);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Message Sent Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error sending message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnRefreshInbox_Click(object sender, EventArgs e)
        {
            LoadMessages();
        }
    }
}
