using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log_and_Sign_Up
{
    class DataContainerClass
    {
        private SortedList userDataContainer = new SortedList();

        private void DefaultData()
        {
            userDataContainer.Add("allen300","12345678");
            userDataContainer.Add("Kala_Phantom","coding@last");
            userDataContainer.Add("ExoticButters","FreedieFazbear");
        }

        public void InitializeDefaultData()
        {
            DefaultData();  
        }

        public void ValidateData()
        {
            string userPassword = Program.UserPassword;
            string userName = Program.UserName;

            if (userDataContainer.ContainsKey(userName) && userDataContainer.ContainsValue(userPassword))
            {
                
            }
        }

     
    }
}
