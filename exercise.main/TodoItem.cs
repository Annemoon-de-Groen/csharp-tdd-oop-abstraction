using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class TodoItem
    {

        private string title;
        private string detail;
        public Status Status;
        private DateTime _createdOn;


        public DateTime CreatedOn { get { return _createdOn; } }
        public TodoItem(String title, String detail, Status status = Status.NotDone)
        {
            this.title = title;
            this.detail = detail;
            this.Status = status;
            _createdOn = DateTime.Now;
        }
    }

    public enum Status
    {
        NotDone,
        Doing,
        Done
    }
}
