using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace AIRFLIGHTS
{
    public partial class View_Details : UserControl
    {
        bool c = false;
        string location = Directory.GetCurrentDirectory();
        public View_Details()
        {
            InitializeComponent();
            LocalDestination.Enabled = false;
            International.Enabled = false;
        }

        private void Rlocal_CheckedChanged(object sender, EventArgs e)
        {
            LocalDestination.Enabled = true;
            International.Enabled = false;
        }

        private void Rinternational_CheckedChanged(object sender, EventArgs e)
        {
            International.Enabled = true;
            LocalDestination.Enabled = false;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Rinternational.Checked == true|| Rlocal.Checked == true)
            {if(Rlocal.Checked==true)
            {
                try{
                if(string.IsNullOrEmpty(origin.Text)||string.IsNullOrEmpty(LocalDestination.Text)||string.IsNullOrEmpty(cabinclass.Text))
                {
                    throw  new ArgumentNullException();
                }
                LOCAL_FLIGHT l3 = new LOCAL_FLIGHT();
                c = l3.location_check(origin.Text, LocalDestination.Text);

                if (c)
                {
                    throw new InvalidLocationException("Origin and destination location cannot be same");
                }
                
                    DirectoryInfo d1 = new DirectoryInfo(location + "\\Local\\" + origin.Text + "\\" + LocalDestination.Text + "\\" + cabinclass.Text + "\\");
                    FileInfo[] f1 = d1.GetFiles();
                    label4.ResetText();
                    foreach (FileInfo f in f1)
                    {
                        string a1 = Path.GetFileNameWithoutExtension(f.Name);

                        label4.Text = label4.Text + a1 + "\n";
                    }
                    ori_local.ResetText();
                    lbs.Text = "Business Class";
                    lec.Text = "Economic Class";
                    lpec.Text = "Premium Economy Class";
                    lfc.Text = "First Class";
                    ori_local.Text = origin.Text + " to " + LocalDestination.Text;
                    lbs.Text = lbs.Text + " " + Directory.GetFiles(location + "\\Local\\" + origin.Text + "\\" + LocalDestination.Text + "\\Business Class\\").Length.ToString() + "/3";
                    lec.Text = lec.Text + " " + Directory.GetFiles(location + "\\Local\\" + origin.Text + "\\" + LocalDestination.Text + "\\Economy Class\\").Length.ToString() + "/6";
                    lpec.Text = lpec.Text + " " + Directory.GetFiles(location + "\\Local\\" + origin.Text + "\\" + LocalDestination.Text + "\\Premium Economy Class\\").Length.ToString() + "/9";
                    lfc.Text = lfc.Text + " " + Directory.GetFiles(location + "\\Local\\" + origin.Text + "\\" + LocalDestination.Text + "\\First Class\\").Length.ToString() + "/2";



            }
            
                catch(ArgumentNullException)
                {
                    MessageBox.Show("Kindly Fill All The Fields");
                }
                catch (InvalidLocationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch(DirectoryNotFoundException)
                {
                    MessageBox.Show("Record not found cannot access data files");
                }
                
            }


                if(Rinternational.Checked==true)
            {
                try{
                    if (string.IsNullOrEmpty(origin.Text) || string.IsNullOrEmpty(International.Text) || string.IsNullOrEmpty(cabinclass.Text))
                {
                    throw  new ArgumentNullException();
                }
                    
                    DirectoryInfo d1 = new DirectoryInfo(location + "\\International\\" + origin.Text + "\\" + International.Text + "\\" + cabinclass.Text + "\\");
                    FileInfo[] f1 = d1.GetFiles();
                    label4.ResetText();
                    foreach (FileInfo f in f1)
                    {
                        string a1 = Path.GetFileNameWithoutExtension(f.Name);
                        label4.Text = label4.Text + a1 + "\n";
                    }

                    int_ori.ResetText();
                    
                    bs.Text = "Business Class";
                    ec.Text = "Economic Class";
                    ecppr.Text = "Premium Economy Class";
                    fc.Text = "First Class";
                    int_ori.Text = origin.Text + " to " + International.Text;
                    bs.Text = bs.Text + " " + Directory.GetFiles(location + "\\International\\" + origin.Text + "\\" + International .Text+ "\\Business Class\\").Length.ToString() + "/7";
                    ec.Text = ec.Text + " " + Directory.GetFiles(location + "\\International\\" + origin.Text + "\\" + International.Text + "\\Economy Class\\").Length.ToString() + "/9";
                    ecppr.Text = ecppr.Text + " " + Directory.GetFiles(location + "\\International\\" + origin.Text + "\\" + International.Text + "\\Premium Economy Class\\").Length.ToString() + "/10";
                    fc.Text = fc.Text + " " + Directory.GetFiles(location + "\\International\\" + origin.Text + "\\" + International.Text + "\\First Class\\").Length.ToString() + "/4";



            }
            
                catch(ArgumentNullException)
                {
                    MessageBox.Show("Kindly Fill All The Fields");
                }
               
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show("Record not found cannot access data files");
                }
            }

            }
            else MessageBox.Show("Please Select Flight Type");

        }

        private void showdetail_Click(object sender, EventArgs e)
        {
            if (Rinternational.Checked == true || Rlocal.Checked == true)
            {
                if (Rlocal.Checked == true)
                {
                    try
                    {
                        if (string.IsNullOrEmpty(origin.Text) || string.IsNullOrEmpty(LocalDestination.Text) || string.IsNullOrEmpty(cabinclass.Text))
                        {
                            throw new ArgumentNullException();
                        }
                       
                        LOCAL_FLIGHT l3 = new LOCAL_FLIGHT();
                        c = l3.location_check(origin.Text, LocalDestination.Text);

                        if (c)
                        {
                            throw new InvalidLocationException("Origin and destination location cannot be same");
                        }
                         FLIGHT f3 = new LOCAL_FLIGHT();

                       if( f3.reader(origin.Text, LocalDestination.Text, cabinclass.Text,enterpass.Text))
                        MessageBox.Show(f3.First_name + f3.Last_name + f3.Address + f3.Mobile_no + f3.Cnic + f3.Passport_no + f3.Origin + f3.Destination + f3.Cabin_class + f3.Way + f3.SeatNo);
                        else
                           MessageBox.Show("Record Not Found");

                      

                    }
                        
                    catch (ArgumentNullException)
                    {
                        MessageBox.Show("Kindly Fill All The Fields");
                    }
                    catch(InvalidLocationException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }


                if (Rinternational.Checked == true)
                {
                    try
                    {
                        if (string.IsNullOrEmpty(origin.Text) || string.IsNullOrEmpty(International.Text) || string.IsNullOrEmpty(cabinclass.Text))
                        {
                            throw new ArgumentNullException();
                        }
                        LOCAL_FLIGHT l3 = new LOCAL_FLIGHT();
                        c = l3.location_check(origin.Text, LocalDestination.Text);

                        if (c)
                        {
                            throw new InvalidLocationException("Origin and destination location cannot be same");
                        }
                        FLIGHT f3 = new INTERNATIONAL_FLIGHT();

                        if (f3.reader(origin.Text, International.Text, cabinclass.Text, enterpass.Text))
                            MessageBox.Show(f3.First_name + f3.Last_name + f3.Address + f3.Mobile_no + f3.Cnic + f3.Passport_no + f3.Origin + f3.Destination + f3.Cabin_class + f3.Way + f3.SeatNo);
                        else
                            MessageBox.Show("Record Not Found");


                    }

                    catch (ArgumentNullException)
                    {
                        MessageBox.Show("Kindly Fill All The Fields");
                    }
                    catch (InvalidLocationException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                   

                }

            }
            else MessageBox.Show("Please Select Flight Type");

        }
    }
}
