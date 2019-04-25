using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using MetroFramework;

namespace IBANCheck
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        Checker checker;

        OpenFileDialog openFileDialog;
        string[] linesFromFile;

        public Form1()
        {
            InitializeComponent();

            checker = new Checker();
        }

        private void btnCheckEntered_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIBAN.Text))
            {
                switch (checker.CheckIBAN(txtIBAN.Text))
                {
                    case 0:
                        lblEnteredResult.Text = "Provided IBAN is correct.";
                        lblEnteredResult.ForeColor = Color.Green;
                        lblEnteredResult.Visible = true;
                        break;

                    case 1:
                        lblEnteredResult.Text = "Provided IBAN is structured incorrectly.";
                        lblEnteredResult.ForeColor = Color.Red;
                        lblEnteredResult.Visible = true;
                        break;

                    case 2:
                        lblEnteredResult.Text = "Country code of provided IBAN is incorrect.";
                        lblEnteredResult.ForeColor = Color.Red;
                        lblEnteredResult.Visible = true;
                        break;

                    case 3:
                        lblEnteredResult.Text = "Total IBAN length for this country is incorrect.";
                        lblEnteredResult.ForeColor = Color.Red;
                        lblEnteredResult.Visible = true;
                        break;

                    case 4:
                        lblEnteredResult.Text = "Provided IBAN is structured incorrectly for this country.";
                        lblEnteredResult.ForeColor = Color.Red;
                        lblEnteredResult.Visible = true;
                        break;

                    case 5:
                        lblEnteredResult.Text = "Provided IBAN is incorrect.";
                        lblEnteredResult.ForeColor = Color.Red;
                        lblEnteredResult.Visible = true;
                        break;

                    default:
                        lblEnteredResult.Visible = false;
                        break;
                }
            }
            else
            {
                lblEnteredResult.Text = "Input field is empty.";
                lblEnteredResult.ForeColor = Color.Red;
                lblEnteredResult.Visible = true;
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            lblFileResult.Text = "Data successfully saved to file.";
            lblFileResult.ForeColor = Color.Green;
            lblFileResult.Visible = false;

            openFileDialog = new OpenFileDialog()
            {
                FileName = "Select a text file",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text file"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = openFileDialog.FileName;

                try //Try reading from file
                {
                    linesFromFile = System.IO.File.ReadAllLines(txtFile.Text);
                }
                catch (Exception ex)
                {
                    lblFileResult.Text = "Error reading data from file.";
                    lblFileResult.ForeColor = Color.Red;
                    lblFileResult.Visible = true;
                }

                checker.CheckIBANsFromFile(linesFromFile);

                try //Try writing to file
                {
                    string pathToResultFile = txtFile.Text.Substring(0, txtFile.Text.Length - 4) + ".out"; //Removing .txt and adding .out
                    StreamWriter writer = new StreamWriter(pathToResultFile);
                    foreach (string line in linesFromFile)
                    {
                        writer.WriteLine(line);
                    }
                    writer.Close();
                }
                catch (Exception ex)
                {
                    lblFileResult.Text = "Error saving data to file.";
                    lblFileResult.ForeColor = Color.Red;
                    lblFileResult.Visible = true;
                }

                lblFileResult.Visible = true; //If none of the catch'es happened
            }
        }
    }
}
