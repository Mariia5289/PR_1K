using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PR_1K.ADO.NET;

namespace PR_1K
{
    public partial class FormAutorization : System.Windows.Forms.Form
    {
        public FormAutorization()
        {
            InitializeComponent();
        }

        private void FormAutorization_Load(object sender, EventArgs e)
        {

        }
        public static Users Enter_User;
        private void button1_Click(object sender, EventArgs e)
        {
            Enter_User = null;
            Model1 model1 = new Model1();
            Enter_User = model1.Users.FirstOrDefault(x => x.Login == textLogin.Text && x.Password == textPassword.Text);
            if ( Enter_User != null )
            {
                switch ( Enter_User.RoleID )
                {
                    case 1:
                    FormManager formManager = new FormManager();
                    formManager.ShowDialog();
                    break;
                    case 2:
                        FormSeller formSeller = new FormSeller();
                        formSeller.ShowDialog();
                        break;
                    case 3:
                        FormDirector formDirector = new FormDirector();
                        formDirector.ShowDialog();
                        break;
                        default: throw new Exception("Роль не найдена!");
                }
            }
        }
    }
}
