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

namespace AIRFLIGHTS
{
    public partial class Form1 : Form
    {
        string rdio = null;
        bool c = false,d=false;
        public Form1()
        {
            InitializeComponent();

            panel2.BringToFront();
           this. panel3.AutoScroll = true;
           
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EnquiryPanel.BringToFront();
            HomeTeal.Visible = false;
            enquiryTeal.Visible = true;
            reservation.Visible = false;
            cancil.Visible = false;
            about.Visible = false;
            pictureBox1.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
            panel2.BringToFront();
            HomeTeal.Visible = true;
            enquiryTeal.Visible = false;
            reservation.Visible = false;
            cancil.Visible = false;
            about.Visible = false;

            pictureBox1.BringToFront();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            HomeTeal.Visible = false;
            enquiryTeal.Visible = false;
            reservation.Visible = true;
            cancil.Visible = false;
            about.Visible = false;
            RegistrationPanel.Visible = true;
            RegistrationPanel.BringToFront();
            panel2.BringToFront();
            pictureBox1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Aboutpanel.BringToFront();
            HomeTeal.Visible = false;
            enquiryTeal.Visible = false;
            reservation.Visible = false;
            cancil.Visible = false;
            about.Visible = true;

            pictureBox1.BringToFront();
        }




        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void login_Click(object sender, EventArgs e)
        {

            if (userName.Text == "ADMIN" && pasword.Text == "ADMIN" || userName.Text == "admin" && pasword.Text == "admin")
            {

                panel4.Visible = false;
            }
            else MessageBox.Show("Invalid Password Or UserName");
            
        }

        private void LocalDestinationSelection_CheckedChanged(object sender, EventArgs e)
        {
            if (LocalDestinationSelection.Checked)
            {

                InternationalDestinationSelectionBox.Enabled = false;
                LocalDestinationSelectionBox.Enabled = true;
            }
        }

        private void InternationalDestinationSelection_CheckedChanged(object sender, EventArgs e)
        {
            if (InternationalDestinationSelection.Checked)
                LocalDestinationSelectionBox.Enabled = false;
            InternationalDestinationSelectionBox.Enabled = true;
        }

        private void RegistrationFinishButton_Click(object sender, EventArgs e)
        {
            if (LocalDestinationSelection.Checked)
            {
                try
                {
                    if (string.IsNullOrEmpty(FirstnameBox.Text) || string.IsNullOrEmpty(LastnameBox.Text) || string.IsNullOrEmpty(AddressBox.Text) || string.IsNullOrEmpty(MobileNumberBox.Text) || string.IsNullOrEmpty(NICNumberBox.Text) || string.IsNullOrEmpty(PassportNumberBox.Text) || string.IsNullOrEmpty(OriginSelectionBox.Text) || string.IsNullOrEmpty(CabinClassSelectionBox.Text) || string.IsNullOrEmpty(LocalDestinationSelectionBox.Text) || string.IsNullOrEmpty(rdio))
                        throw new ArgumentNullException();
                    LOCAL_FLIGHT l1 = new LOCAL_FLIGHT();
                    c = l1.location_check(OriginSelectionBox.Text, LocalDestinationSelectionBox.Text);

                    if (c)
                    {
                        throw new InvalidLocationException("Origin and destination location cannot be same");
                    }
                    FLIGHT f1 = new LOCAL_FLIGHT(FirstnameBox.Text, LastnameBox.Text, AddressBox.Text, MobileNumberBox.Text, NICNumberBox.Text, PassportNumberBox.Text, OriginSelectionBox.Text, LocalDestinationSelectionBox.Text, CabinClassSelectionBox.Text, rdio);
                    if (f1.register())
                    {
                        f1.reader();
                       
                        MessageBox.Show(f1.First_name + f1.Last_name + f1.Address + f1.Mobile_no + f1.Cnic + f1.Passport_no + f1.Origin + f1.Destination + f1.Cabin_class + f1.Way+f1.SeatNo);
                        FLIGHT f3 = new LOCAL_FLIGHT();
                       
                    }
                    else
                    {
                        MessageBox.Show(CabinClassSelectionBox.Text+" SEATS FULL");
                    }
                    FirstnameBox.Clear();
                    LastnameBox.Clear();
                    AddressBox.Clear();
                    MobileNumberBox.Clear();
                    NICNumberBox.Clear();
                    PassportNumberBox.Clear();

                    LocalDestinationSelection.Checked = false;
                    InternationalDestinationSelection.Checked = false;
                    OriginSelectionBox.ResetText();
                    LocalDestinationSelectionBox.ResetText();
                    InternationalDestinationSelectionBox.ResetText();
                    CabinClassSelectionBox.ResetText();
                    OneWay.Checked = false;
                    Return.Checked = false;
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Kindly Fill All The Fields");
                }
                catch (InvalidLocationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch(DirectoryNotFoundException)
                {
                    MessageBox.Show("Directory not found reserve seat  ");
                }
                catch(PathTooLongException)
                {
                    MessageBox.Show("INVALID PASSPORT NUMBER");
                }

            }
            if (InternationalDestinationSelection.Checked)
            {
                try
                {
                    if (string.IsNullOrEmpty(FirstnameBox.Text) || string.IsNullOrEmpty(LastnameBox.Text) || string.IsNullOrEmpty(AddressBox.Text) || string.IsNullOrEmpty(MobileNumberBox.Text) || string.IsNullOrEmpty(NICNumberBox.Text) || string.IsNullOrEmpty(PassportNumberBox.Text) || string.IsNullOrEmpty(OriginSelectionBox.Text) || string.IsNullOrEmpty(CabinClassSelectionBox.Text) || string.IsNullOrEmpty(InternationalDestinationSelectionBox.Text) || string.IsNullOrEmpty(rdio))
                        throw new ArgumentNullException();


                    FLIGHT f2 = new INTERNATIONAL_FLIGHT(FirstnameBox.Text, LastnameBox.Text, AddressBox.Text, MobileNumberBox.Text, NICNumberBox.Text, PassportNumberBox.Text, OriginSelectionBox.Text, InternationalDestinationSelectionBox.Text, CabinClassSelectionBox.Text, rdio);
                    
                  if(  f2.register())
                  {
                      f2.reader();
                      MessageBox.Show(f2.First_name + f2.Last_name + f2.Address + f2.Mobile_no + f2.Cnic + f2.Passport_no + f2.Origin + f2.Destination + f2.Cabin_class + f2.Way+f2.SeatNo);

                  }
                    else
                  {
                      MessageBox.Show(CabinClassSelectionBox.Text+" SEATS FULL");
                  }
                    FirstnameBox.Clear();
                    LastnameBox.Clear();
                    AddressBox.Clear();
                    MobileNumberBox.Clear();
                    NICNumberBox.Clear();
                    PassportNumberBox.Clear();

                    LocalDestinationSelection.Checked = false;
                    InternationalDestinationSelection.Checked = false;
                    OriginSelectionBox.ResetText();
                    LocalDestinationSelectionBox.ResetText();
                    InternationalDestinationSelectionBox.ResetText();
                    CabinClassSelectionBox.ResetText();
                    OneWay.Checked = false;
                    Return.Checked = false;
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Kindly Fill All The Fields");
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show("Directory not found cannot reserve seat ");
                }
                catch (PathTooLongException)
                {
                    MessageBox.Show("INVALID PASSPORT NUMBER");
                }
               
                

            }



        }

        private void checkradio(object sender, EventArgs e)
        {
            RadioButton r1 = (RadioButton)sender;
            rdio = r1.Text;
        }

        private void LocalFlightButton_Click(object sender, EventArgs e)
        {
            LocalFlightPanle.BringToFront();
            
           
            pictureBox1.BringToFront();
        }

        private void InternationalFlightsButton_Click(object sender, EventArgs e)
        {
            InternationalFlightsPanel.BringToFront();
            
           
            pictureBox1.BringToFront();

        }

        private void ticketcancel_Click(object sender, EventArgs e)
        {
            CancelationPanel.BringToFront();

            HomeTeal.Visible = false;
            enquiryTeal.Visible = false;
            reservation.Visible = false;
            cancil.Visible = true;
            about.Visible = false;
            pictureBox1.BringToFront();

        }

        private void BackFromChina_Click(object sender, EventArgs e)
        {
            InternationalFlightsPanel.BringToFront();
            panel1.BringToFront();
            
            pictureBox1.BringToFront();
        }

        private void Karachidetail_Click(object sender, EventArgs e)
        {
            KarachiDetailpanel.BringToFront();
            panel1.BringToFront();
           
            pictureBox1.BringToFront();
        }

        private void Lahoredetail_Click(object sender, EventArgs e)
        {
            LahoreDetailpanel.BringToFront();
            panel1.BringToFront();
            
            pictureBox1.BringToFront();
        }

        private void islamabaddetail_Click(object sender, EventArgs e)
        {
            IslamabadDetailpanel.BringToFront();
            panel1.BringToFront();
            
            pictureBox1.BringToFront();
        }

        private void Faislabaddetail_Click(object sender, EventArgs e)
        {
            FaisalabadDetailPanel.BringToFront();
            panel1.BringToFront();
           
            pictureBox1.BringToFront();
        }

        private void peshawardetails_Click(object sender, EventArgs e)
        {
            PeshawerDetailpanel.BringToFront();
            panel1.BringToFront();
           
            pictureBox1.BringToFront();
        }

        private void BackFromKarachi_Click(object sender, EventArgs e)
        {

            LocalFlightPanle.BringToFront();
            panel1.BringToFront();
          
            pictureBox1.BringToFront();

        }

        private void SudiaDetailButton_Click(object sender, EventArgs e)
        {
            SaudiaDetailPanel.BringToFront();
            panel1.BringToFront();
          
            pictureBox1.BringToFront();
        }

        private void DubaiDetailButton_Click(object sender, EventArgs e)
        {
            DubaiDetailPanel.BringToFront();
            panel1.BringToFront();
            
            pictureBox1.BringToFront();
        }

        private void AmericaDetailButton_Click(object sender, EventArgs e)
        {
            AmericaDetailPanel.BringToFront();
            panel1.BringToFront();
            
            pictureBox1.BringToFront();
        }

        private void LondonDetailButton_Click(object sender, EventArgs e)
        {
            LondonDetailPanel.BringToFront();
            panel1.BringToFront();
          
            pictureBox1.BringToFront();
        }

        private void ChinaDetailButton_Click(object sender, EventArgs e)
        {
            ChinaDetailPanel.BringToFront();
            panel1.BringToFront();
            
            pictureBox1.BringToFront();
        }

        private void RussiaDetailButton_Click(object sender, EventArgs e)
        {
            RussiaDetailPanel.BringToFront();
            panel1.BringToFront();
            
            pictureBox1.BringToFront();
        }

        private void UnitedKingdomDetailButton_Click(object sender, EventArgs e)
        {
            UnitedKingdomDetailPanel.BringToFront();
            panel1.BringToFront();
            
            pictureBox1.BringToFront();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (CLocalDestinationSelection.Checked)
            {
                try
                {
                    if (string.IsNullOrEmpty(CPassportNumberBox.Text) || string.IsNullOrEmpty(COriginSelectionBox.Text) || string.IsNullOrEmpty(CLocalDestinationSelectionBox.Text))
                    {
                        throw new ArgumentNullException();
                    }
                    LOCAL_FLIGHT l2 = new LOCAL_FLIGHT();
                    d = l2.location_check(COriginSelectionBox.Text, CLocalDestinationSelectionBox.Text);
                    if (d)
                    {
                        throw new InvalidLocationException("Origin and destination location cannot be same");
                    }
                    FLIGHT l3 = new LOCAL_FLIGHT();
                    if (l3.cancel(CPassportNumberBox.Text, COriginSelectionBox.Text, CLocalDestinationSelectionBox.Text,Ccabinclass.Text))
                    {
                        MessageBox.Show("Cancel Successfully");
                    }
                    else
                        MessageBox.Show("Record not fount");

                    CPassportNumberBox.Clear();
                    COriginSelectionBox.ResetText();
                    CLocalDestinationSelectionBox.ResetText();
                    CLocalDestinationSelection.Checked = false;
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
                
            if (CInternationalDestinationSelection.Checked)
            {
                try
                {
                    if (string.IsNullOrEmpty(CPassportNumberBox.Text) || string.IsNullOrEmpty(COriginSelectionBox.Text) || string.IsNullOrEmpty(CInternationalDestinationSelectionBox.Text))
                    {
                        throw new ArgumentNullException();
                    }
         FLIGHT l4 = new INTERNATIONAL_FLIGHT();



         if (l4.cancel(CPassportNumberBox.Text, COriginSelectionBox.Text, CInternationalDestinationSelectionBox.Text, Ccabinclass.Text))
         {
             MessageBox.Show("Cancel Successfully");
         }
         else
             MessageBox.Show("Record not found");
                   
                    CPassportNumberBox.Clear();
                    COriginSelectionBox.ResetText();
                    CLocalDestinationSelectionBox.ResetText();
                    CLocalDestinationSelection.Checked = false;
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Kindly Fill All The Fields");
                }
              
                
            }
        }

        private void CLocalDestinationSelection_CheckedChanged(object sender, EventArgs e)
        {
            CLocalDestinationSelectionBox.Enabled = true;
            CInternationalDestinationSelectionBox.Enabled = false;
        }

        private void CInternationalDestinationSelection_CheckedChanged(object sender, EventArgs e)
        {
            CLocalDestinationSelectionBox.Enabled = false;
            CInternationalDestinationSelectionBox.Enabled = true;
        }

      

        

      
      

        private void ViewDetails_Click(object sender, EventArgs e)
        {
            view_Details1.BringToFront();
            panel1.BringToFront();
            
            pictureBox1.BringToFront();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel3.Location = new Point(222, -vScrollBar1.Value * 15);
        }

        private void BackFromDubai_Click(object sender, EventArgs e)
        {
            InternationalFlightsPanel.BringToFront();
            panel2.BringToFront();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

     
    }
}
