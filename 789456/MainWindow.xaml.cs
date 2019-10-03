using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _789456
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int dem = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, RoutedEventArgs e)
        {
            lbxtinh.Items.Add("STT" + "\t\t Cạnh" + "\t Chu vi" + "\t Diện tích");
            hinhvuong[] hv = new hinhvuong[5];
            hv[0] = new hinhvuong(3);
            hv[1] = new hinhvuong(4);
            hv[2] = new hinhvuong(5);
            hv[3] = new hinhvuong(6);
            hv[4] = new hinhvuong(7);
            for (int i = 0; i < 5; i++)
            {
                hv[i].Cv();
                hv[i].Dt();
                dem += 1;
                lbxtinh.Items.Add("\nHình Vuông: " + dem.ToString() + "\t" + hv[i].Canh + "  \t " + hv[i].chuvi.ToString() + "\t " + hv[i].dientich.ToString());
            }
            }
            private void btnhinhtron_Click(object sender, RoutedEventArgs e)
        {
            lbx2.Items.Add("STT" + "\t\t " + "\t Chu vi" + "\t Diện tích");
            List<hinhtron> ht = new List<hinhtron>();
            ht.Add(new hinhtron(3));
            ht.Add(new hinhtron(4));
            ht.Add(new hinhtron(5));
            ht.Add(new hinhtron(6));
            ht.Add(new hinhtron(7));
            foreach (hinhtron ci in ht)
            {
                dem += 1;
                ci.Cv();
                ci.Dt();
                lbx2.Items.Add("\nHình tròn: " + dem.ToString() + "\t " + (ci.bankinh) + "  \t " + ci.chuvi.ToString() + "\t " + ci.dientich.ToString());
            }
        }
            }

        }

