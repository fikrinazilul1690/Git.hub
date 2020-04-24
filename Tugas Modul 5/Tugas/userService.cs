using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas
{
    class userService
    {
        private string[,] data;
        private string email, password, roles = "";
        private string[,] histories;
        private string akun, buku1, buku2, tanggal = ""; 

        public userService(string emails, string passwords)
        {
            email = emails;
            password = passwords;
            data = new string[2, 3] {
                {"fikri_23@gmail.com", "ini_modul_5", "super Admin" },
                {"seto_23@gmail.com", "modul_5", "user"  }
            };

            histories = new string[2, 4]
            {
                {"fikri_23@gmail.com", "Fisika dasar","Dasar Komputer dan Pemrograman", "24-04-2020"},
                {"seto_23@gmail.com", "Teka teki silang","Buku gambar", "24-04-2020"}

            };
        }

        public void login()
        {
            var (status, role) = checkCredentials();
            if (status == true)
            {
                Console.WriteLine("\nWelcome " + role);
                Console.WriteLine("Logged it as user email: " + email + "\n");
                Console.WriteLine(akun + " Meminjam buku :\n" + buku1 + "\n" + buku2);
                Console.WriteLine("Tanggal Peminjaman : "+ tanggal);

            }
            else
            {
                Console.WriteLine("\nInvalid Login");
            }
        }
        private (bool, string) checkCredentials()
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 0] == email && data[i, 1] == password)
                {
                    roles = data[i, 2];
                    akun = histories[i, 0];
                    buku1 = histories[i, 1];
                    buku2 = histories[i, 2];
                    tanggal = histories[i, 3];
                    return (true, roles);
                }
            }
            return (false, roles);
        }

    }
}
