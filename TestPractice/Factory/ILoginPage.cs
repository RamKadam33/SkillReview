using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice.Factory
{
    public interface ILoginPage
    {
        void EnterUsername(string username);
        void EnterPassword(string password);
        void ClickLogin();
    }
}
