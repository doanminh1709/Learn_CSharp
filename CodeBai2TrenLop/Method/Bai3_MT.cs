using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Bai3_MT
    {
        static void Main(string[] args)
        {
            int chi_so_dau = 0, chi_so_cuoi = 0;
            NhapB3(ref chi_so_dau, ref chi_so_cuoi);
            Console.WriteLine("Tinh tien : " + TinhTien(chi_so_dau, chi_so_cuoi));
        }
        static void NhapB3(ref int chi_so_dau, ref int chi_so_cuoi)
        {
            Console.WriteLine(" Nhap chi so dau : ");
            chi_so_dau = int.Parse(Console.ReadLine());

            Console.WriteLine(" Nhap chi so cuoi : ");
            chi_so_cuoi = int.Parse(Console.ReadLine());


        }
        static int TinhTien(int chi_so_dau, int chi_so_cuoi)
        {
                int t = chi_so_cuoi - chi_so_dau;
                if (t > 0 && t <= 100)
                {
                    return t * 2000;
                }
                else if (t <= 150)
                {
                    return 100 * 2000 + (t - 100) * 2500;

                }
                else if (t <= 200)
                {
                    return 100 * 2000 + 50 * 2500 + (t - 150) * 2800;
                }
                else
                {
                    return 100 * 2000 + 50 * (2500 + 2800) + (t - 200) * 3500;

                }
            }
        }
    }
