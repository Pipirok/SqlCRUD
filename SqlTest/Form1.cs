using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using SqlTest.db;

namespace SqlTest
{
    public partial class FormSQL : Form
    {
        public FormSQL()
        {
            InitializeComponent();
        }


        // 1 - select, 2 - update, 3 - create, 4 - delete
        private int currentOperation = 1;

        private void OnRadioSelect(int operation)
        {
            currentOperation = operation;
            switch (operation)
            {
                case 1:
                    textBoxName.Enabled = false;
                    textBoxID.Enabled = true;
                    break;
                case 2:
                    textBoxName.Enabled = true;
                    textBoxID.Enabled = true;
                    break;
                case 3:
                    textBoxName.Enabled = true;
                    textBoxID.Enabled = false;
                    break;
                default:
                    textBoxName.Enabled = false;
                    textBoxID.Enabled = true;
                    break;
            }
        }

        private void SqlOperation()
        {
            switch (currentOperation)
            {
                case 1:
                    try
                    {
                        int ID = int.Parse(textBoxID.Text);
                        PopulateGridview(ID);
                        return;
                    }
                    catch
                    {
                        PopulateGridview();
                    }
                    break;
                case 2:
                    try
                    {
                        int.Parse(textBoxID.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Enter a proper ID (a number)", "ID Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (textBoxName.TextLength == 0)
                    {
                        MessageBox.Show("Enter a proper name", "Name Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    bool isUpdated = UserDAL.UpdateUser(textBoxID.Text, textBoxName.Text);
                    if (!isUpdated)
                    {
                        MessageBox.Show("Error while updating the user", "Update error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    textBoxID.Text = "";
                    textBoxName.Text = "";

                    PopulateGridview();
                    break;
                case 3:
                    if (textBoxName.TextLength == 0)
                    {
                        MessageBox.Show("Enter a proper name", "Name Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    bool isInserted = UserDAL.CreateUser(textBoxName.Text);
                    if (!isInserted)
                    {
                        MessageBox.Show("Error while inserting the user", "Insert error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    textBoxID.Text = "";
                    textBoxName.Text = "";

                    PopulateGridview();
                    break;
                default:
                    try
                    {
                        int.Parse(textBoxID.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Enter a proper ID (a number)", "ID Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    bool isDeleted = UserDAL.DeleteUser(textBoxID.Text);
                    if (!isDeleted)
                    {
                        MessageBox.Show("Error while deleting the user", "Delete error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    textBoxID.Text = "";
                    textBoxName.Text = "";

                    PopulateGridview();
                    break;
            }
        }

        private void PopulateGridview(int ID = -1)
        {

            // `Users` table starts from 1
            if (ID < 0)
            {

                GridViewOutput.DataSource = UserDAL.GetUsers();

            }
            else
            {
                GridViewOutput.DataSource = UserDAL.GetUserByID(ID);
            }
            textBoxID.Text = "";
            textBoxName.Text = "";
        }

        private void FormSQL_Load(object sender, EventArgs e)
        {
            PopulateGridview();
        }

        private void rButtonSelect_CheckedChanged(object sender, EventArgs e)
        {
            OnRadioSelect(1);
        }

        private void rButtonUpdate_CheckedChanged(object sender, EventArgs e)
        {
            OnRadioSelect(2);
        }

        private void rButtonCreate_CheckedChanged(object sender, EventArgs e)
        {
            OnRadioSelect(3);
        }

        private void rButtonDelete_CheckedChanged(object sender, EventArgs e)
        {
            OnRadioSelect(4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlOperation();
        }
    }
}
