using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AIRFLIGHTS
{
  abstract  class FLIGHT
  {
     protected string first_name, last_name, address, mobile_no, CNIC, passport_no;
    protected string origin, destination, cabinclass, way,seatno;
 protected   string location = Directory.GetCurrentDirectory();
 
      public abstract bool register();
      public abstract void reader();
      public abstract bool cancel(string passport_no, string origin, string destination,string cab_class);
      public abstract bool reader(String origin, string destination, string cabinclass, string passport_no);
      public string First_name
      {
          get { return first_name; }
      }
      public string Last_name
      {
          get { return last_name; }
      }
      public string Address
      {
          get { return address; }
      }
      public string Mobile_no
      {
          get { return mobile_no; }
      }
      public string Cnic
      {
          get { return CNIC; }
      }
      public string Passport_no
      {
          get { return passport_no; }
      }
      public string Origin
      {
          get { return origin; }
      }
      public string Destination
      {
          get { return destination; }
      }
      public string Cabin_class
      {
          get { return cabinclass; }
      }
      public string Way
      {
          get { return way; }
      }
      public string SeatNo
      {
          get { return seatno; }
      }
    }
}
