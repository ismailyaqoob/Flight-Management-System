using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AIRFLIGHTS
{
    class INTERNATIONAL_FLIGHT:FLIGHT
    {public INTERNATIONAL_FLIGHT (string first_name, string last_name, string address, string mobile_no, string CNIC, string passport_no, string origin, string destination, string cabinclass, string way)
 {
     this.first_name = first_name;
     this.last_name = last_name;
     this.address = address;
     this.mobile_no = mobile_no;
     this.CNIC = CNIC;
     this.passport_no = passport_no;
     this.origin = origin;
     this.destination = destination;
     this.cabinclass = cabinclass;
     this.way = way;
     seatno = "" + origin[0] + origin[1] + cabinclass[0] + cabinclass[1] + Directory.GetFiles(location + "\\International\\" + origin + "\\" + destination + "\\" + cabinclass + "\\").Length;

 }
        public INTERNATIONAL_FLIGHT()
    {
        
    }
        public override bool register()
        {
            if ((cabinclass == "Premium Economy Class" && Directory.GetFiles(location + "\\International\\" + origin + "\\" + destination + "\\" + cabinclass + "\\").Length < 10 )|| (cabinclass == "First Class" && Directory.GetFiles(location + "\\International\\" + origin + "\\" + destination + "\\" + cabinclass + "\\").Length < 4) || (cabinclass == "Business Class" && Directory.GetFiles(location + "\\International\\" + origin + "\\" + destination + "\\" + cabinclass + "\\").Length < 7)|| (cabinclass == "Economy Class" && Directory.GetFiles(location + "\\International\\" + origin + "\\" + destination + "\\" + cabinclass + "\\").Length < 9))
            {
                using (BinaryWriter b1 = new BinaryWriter(File.Open(location + "\\International\\" + origin + "\\" + destination + "\\" + cabinclass + "\\" + passport_no + ".dat", FileMode.Create)))
            {
                b1.Write("First Name: " + first_name);
                b1.Write("\nLast Name: " + last_name);
                b1.Write("\nAddress: " + address);
                b1.Write("\nMobile Number: " + mobile_no);
                b1.Write("\nCNIC No.: " + CNIC);
                b1.Write("\nPassport No.: " + passport_no);
                b1.Write("\nOrigin: " + origin);
                b1.Write("\nDestination: " + destination);
                b1.Write("\nClass: " + cabinclass);
                b1.Write("\nType Of Ticket: " + way);
                b1.Write("\nSeat No:" + seatno);
            }
            return true;
        }
else
            return false;
        }
        public override void reader()
        {
            
                using (BinaryReader b2 = new BinaryReader(File.Open(location + "\\International\\" + origin + "\\" + destination + "\\"+cabinclass+"\\" + passport_no + ".dat", FileMode.Open)))
                {


                    first_name = b2.ReadString();
                    last_name = b2.ReadString();
                    address = b2.ReadString();
                    mobile_no = b2.ReadString();
                    CNIC = b2.ReadString();
                    passport_no = b2.ReadString();
                    origin = b2.ReadString();
                    destination = b2.ReadString();
                    cabinclass = b2.ReadString();
                    way = b2.ReadString();
                    seatno = b2.ReadString();

                }
              
        }
        public override bool reader(String origin, string destination, string cabinclass, string passport_no)
        {

            if (File.Exists(location + "\\International\\" + origin + "\\" + destination + "\\" + cabinclass + "\\" + passport_no + ".dat"))
            {
                using (BinaryReader b2 = new BinaryReader(File.Open(location + "\\International\\" + origin + "\\" + destination + "\\" + cabinclass + "\\" + passport_no + ".dat", FileMode.Open)))
                {


                    first_name = b2.ReadString();
                    last_name = b2.ReadString();
                    address = b2.ReadString();
                    mobile_no = b2.ReadString();
                    CNIC = b2.ReadString();
                    this.passport_no = b2.ReadString();
                    this.origin = b2.ReadString();
                    this.destination = b2.ReadString();
                    this.cabinclass = b2.ReadString();
                    way = b2.ReadString();
                    seatno = b2.ReadString();

                }
                return true;
            }
            else return false;

        }
        
           public override bool cancel(string passport_no,string origin,string destination, string cab_class)
        {
            if (File.Exists(location + "\\International\\" + origin + "\\" + destination + "\\" + cab_class + "\\" + passport_no + ".dat"))
            {
                File.Delete(location + "\\International\\" + origin + "\\" + destination + "\\" + cab_class + "\\" + passport_no + ".dat");
                return true;
            }
            else
                return false;
        }
        

        }
    }


