using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    internal class TienDien
    {
        private int chi_so_dau;
        private int chi_so_cuoi;

        public TienDien()
        {
            chi_so_dau = 0;
            chi_so_cuoi = 0;
        }

        public TienDien(int chi_so_dau, int chi_so_cuoi)
        {
            this.chi_so_dau = chi_so_dau;
            this.chi_so_cuoi = chi_so_cuoi;
        }

        public void NhapSoDien()
        {
            Console.WriteLine(" Nhap chi so dien dau : ");
            chi_so_dau = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Nhap chi so dien cuoi ");
            chi_so_cuoi = Convert.ToInt32(Console.ReadLine());
        }

        public int TinhTienDien()
        {
            int soDienSuDung = chi_so_cuoi - chi_so_dau;
            int tienDien = 0;

            if (soDienSuDung > 0 && soDienSuDung <= 100)
            {
                tienDien = soDienSuDung * 2000;
            }
            if(soDienSuDung > 100 && soDienSuDung <= 150)
            {
                tienDien += (soDienSuDung - 100) * 2500; 
            }
            if(soDienSuDung > 2500 && soDienSuDung <= 200)
            {
                tienDien += (soDienSuDung - 150) * 2800;
            }
            if(soDienSuDung > 200)
            {
                tienDien += (soDienSuDung - 200) * 3500;
            }
            return tienDien;
        }
    }
}
