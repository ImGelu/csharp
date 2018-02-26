using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beclean
{
    partial class AboutBox1 : Form
    {
        public AboutBox1()
        {
            InitializeComponent();
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void AboutBox1_Load(object sender, EventArgs e)
        {
            label1.Text = "Beclean, cunoscut și ca Beclean pe Someș, (în maghiară Bethlen, în germană Bethlen) este un oraș în județul Bistrița-Năsăud, Transilvania, România.\n\nSituat pe culoarul Someșul Mare, în aval de confluența Someș-Șieu, în zona de separare a două mari unități de relief Câmpia Transilvaniei și Podișul Someșan, orașul Beclean este al doilea ca mărime după municipiul Bistrița.\n\nAvând ca localități aparținătoare: Rusu de Jos, Coldău și Figa, orașul Beclean are o suprafață de 957,4 ha intravilan și 3579 ha extravilan.\n\nOrașul Beclean are o populație de 10.403 locuitori (români 8493, maghiari 1480, romi 386, germani 10, alte etnii 22, etnie nedeclarata 12).\n\nAtestat documentar din 1235. Ca mijloc de protecție împotriva deselor incursiuni tătare au fost ridicate inițial palisade și valuri de pământ. Cetatea a fost construită ulterior, pe cheltuiala familiei nobiliare Bethlen, de care se leagă numele localității. În timpul revoltei curuților (1703-1711) cetatea a fost serios afectată.\n\n În anul 1848 generalul revoluționar Józef Bem a obținut la Beclean o victorie asupra trupelor imperiale austriece.";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
