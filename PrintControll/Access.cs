using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintControll
{
    [Serializable]
  public  class Access
    {
        public int pagecount;
        public string username;
        public DateTime accesstime;
        public string reason;

        public Access()
        {
            //Default Constructor 

        }

        public Access(string username, int pagecount, DateTime accesstime,string reason)
        {
            this.username = username;
            this.pagecount = pagecount;
            this.accesstime = accesstime;
            this.reason = reason;
        }

       

        /// <summary>
        /// serAccessTime
        /// </summary>
        /// <param name="value"></param>
        public void SetAccesstime(DateTime value)
        {
            accesstime = value;
        }

        /// <summary>
        /// getAccessTime
        /// </summary>
        /// <returns></returns>
        public DateTime GetAccesstime()
        {
            return accesstime;
        }


        /// <summary>
        /// setUsername
        /// </summary>
        /// <param name="value"></param>
        public void SetUsername(string value)
        {
            username = value;
        }

        /// <summary>
        /// getUsername
        /// </summary>
        /// <returns></returns>
        public string GetUsername()
        {
            return username;
        }



        /// <summary>
        /// Set pagecount 
        /// </summary>
        /// <param name="value"></param>
        public void SetpageCount(int value)
        {
            pagecount = value;
        }

        /// <summary>
        /// getPageCount
        /// </summary>
        /// <returns></returns>
        public int GetpageCount()
        {
            return pagecount;
        }


        /// <summary>
        /// set reason
        /// </summary>
        /// <param name="value"></param>
        public void SetReason(string value)
        {
            reason = value;
        }

        /// <summary>
        /// get reason
        /// </summary>
        /// <returns></returns>
        public string GetReason()
        {
            return reason;
        }




    }
}
