namespace BaiKiemTra
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<SinhVien> svs = new List<SinhVien>();
            int cpt = 0;
            do
            {
                Console.WriteLine("**********************************");
                Console.WriteLine("****Đoàn Hữu Minh , 2020608082****");
                Console.WriteLine("**********************************");
                Console.WriteLine("1.Them sinh vien");
                Console.WriteLine("2.Hien thi danh sach");
                Console.WriteLine("3.Xoa sinh vien");
                Console.WriteLine("4.Ket thuc");
                Console.Write("Nhap lua chon cua ban : ");
                cpt = int.Parse(Console.ReadLine());
                switch (cpt)
                {
                    case 1:
                        {
                            SinhVien newSv = new SinhVien();
                            Console.WriteLine("Nhập thông tin sinh viên ");
                            newSv.Input();
                            Nhap(svs, newSv);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-15}{4,-15}",
                                "masv", "diem", "xeploai", "hoten", "phone");
                            foreach (SinhVien s in svs)
                            {
                                Console.WriteLine(s.ToString());
                            }
                            break;
                        }
                    case 3:
                        {
                            XoaSv(svs);
                            break;
                        }
                    case 4:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            } while (true);
        }
        public static void Nhap(List<SinhVien> svs , SinhVien sv)
        {
                foreach (SinhVien svx in svs)
                {
                    if (svx.Equals(sv))
                    {
                        throw new Exception("Không được nhập trùng mã sv".ToUpper());
                  
                    }
                }
                svs.Add(sv);
            Console.WriteLine("Thêm thành công".ToUpper());
        }

        public static void XoaSv(List<SinhVien> svs)
        {
            Console.WriteLine(" Nhap masv muon xoa : ");
            String msv = Console.ReadLine();
       

            SinhVien s = new SinhVien(msv);


            //Cách để tìm sinh viên có tồn tại ở trong list hay không 
            //cách 2 
            SinhVien sv = svs.Find(s => s.MaSv.Equals(msv));
            //nếu trả về khác null có nghĩa nó tồn tại 
            if(sv != null)
            {
                Console.WriteLine("Tồn tại");
            }
            else
            {
                Console.WriteLine("Không tồn tại");
            }


            int index = svs.IndexOf(s);


            if (index != -1)
            {
                int choise = 0;
                do
                {
                    Console.Write("Bạn có chắc chắn muốn xóa\n1.Xóa" +
                        "\n2.Hủy \nLựa chọn của bạn : ");
                    choise = int.Parse(Console.ReadLine());
                } while (choise != 2 && choise != 1);

                if(choise == 1)
                {
                    svs.RemoveAt(index);
                    Console.WriteLine("Xóa thành công");
                }
                else
                {
                    Console.WriteLine("Hủy quá trình xóa");
                }
            }
            else
            {
                Console.WriteLine("Không tồn tại được sinh viên có mã này");
            }
            
        }
    }
}