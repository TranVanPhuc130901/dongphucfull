namespace DongPhucKhanhLinh
{
    public class NumberExtension
    {
        #region Các phương thức cơ bản

        /// <summary>
        /// Định dạng tiền. vd: truyền vào 100000 -> kết quả 100.000
        /// </summary>
        /// <param name="nuber">Giá cần định dạng (vd:100000)</param>
        /// <returns></returns>
        public static string FormatNumber(string nuber)
        {
            if (nuber.Length > 3)
            {
                for (int i = nuber.Length - 3; i > 0; i = i - 3)
                {
                    nuber = nuber.Insert(i, ".");
                }
            }
            return nuber;
        }

        /// <summary>
        /// Định dạng tiền VD1: Formatnuber("100000",false,"","VND") -> 100.000 VND ,<br/>VD2: Formatnuber("0",true,"Liên hệ","VND") -> Liên hệ
        /// </summary>
        /// <param name="nuber">Giá cần định dạng (vd:100000)</param>
        /// <param name="getTextContact">true: kết quả trả về là chữ nếu giá truyền vào bằng 0</param>
        /// <param name="textContact">chữ thay thế khi giá bằng 0 (vd: Liên hệ)</param>
        /// <param name="rateMoney">kí tự tiền tệ (vd: VND)</param>
        /// <returns></returns>
        public static string FormatNumber(string nuber, bool getTextContact, string textContact, string rateMoney)
        {
            if (getTextContact && nuber == "0")
            {
                nuber = textContact;
            }
            else
            {
                for (int i = nuber.Length - 3; i > 0; i -= 3)
                    nuber = nuber.Insert(i, ".");
                nuber += " " + rateMoney;
            }
            return nuber;
        }

        #endregion Các phương thức cơ bản

        #region Đọc số thành chữ

        /// <summary>
        /// Đọc số thành chữ. vd: 103236 -> Một trăm lẻ ba nghìn hai trăm ba mươi sáu
        /// </summary>
        /// <param name="nuber">Giá cần đọc (chú ý phương thức này không để ý đến các ký tự không phải là số. vd: truyền vào 12345 và 12.345 đều có chung một kết quả là: Mười hai nghìn ba trăm bốn mươi năm)</param>
        /// <returns></returns>
        public static string ReadNumber(string nuber)
        {
            try
            {
                string chuoiSo = LoaiKiTuDuThua(nuber);
                string ketqua = DocChuoi(chuoiSo);
                string c = ketqua[0].ToString().ToUpper();
                ketqua = ketqua.Remove(0, 1);
                ketqua = ketqua.Insert(0, c);
                return ketqua;
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// Loại bỏ các ký tự không phải là số trong chuỗi vào( vd: 12.23abc45 -> kết quả 122345) (Phương thức này chỉ dùng để phục vụ xây dựng phương thức Readnuber)
        /// </summary>
        /// <param name="chuoiVao">Chuỗi cần loại bỏ ký tự thừa</param>
        /// <returns></returns>
        public static string LoaiKiTuDuThua(string chuoiVao)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (char c in chuoiVao)
            {
                //Chỉ lấy các kí tự số
                if (LaMotSo(c)) sb.Append(c);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Kiểm tra xem một ký tự có phải là số từ 0 đến 9 hay không. (Phương thức này chỉ dùng để phục vụ xây dựng phương thức Readnuber)
        /// </summary>
        /// <param name="c">Ký tự cần kiểm tra</param>
        /// <returns></returns>
        public static bool LaMotSo(char c)
        {
            if ((int)c >= (int)'0' && (int)c <= (int)'9')
                return true;
            else return false;
        }

        /// <summary>
        /// Thực hiện việc đọc số có 3 chữ số. (Phương thức này chỉ dùng để phục vụ xây dựng phương thức Readnuber)
        /// </summary>
        /// <param name="chuoi">Chuỗi cần đọc</param>
        /// <param name="vitrikitcuoi">Vị trí ký tự cuối</param>
        /// <returns></returns>
        public static string doc3so(string chuoi, int vitrikitcuoi)
        {
            string result = "";
            string tempResult = "";
            for (int i = 0; i < chuoi.Length; i++)
            {
                tempResult = "";
                switch (chuoi[i].ToString())
                {
                    case "0": tempResult += "không "; break;
                    case "1": tempResult += "một "; break;
                    case "2": tempResult += "hai "; break;
                    case "3": tempResult += "ba "; break;
                    case "4": tempResult += "bốn "; break;
                    case "5": tempResult += "năm "; break;
                    case "6": tempResult += "sáu "; break;
                    case "7": tempResult += "bảy "; break;
                    case "8": tempResult += "tám "; break;
                    case "9": tempResult += "chín "; break;
                    default: break;
                }
                if (LaMotSo(chuoi[i]))
                {
                    if (i == 0)
                        tempResult += "trăm ";
                    if (i == 1)
                    {
                        if (chuoi[i].ToString() != "1")
                            tempResult += "mươi ";
                        else
                        {
                            tempResult = "mười ";
                        }
                    }
                    if (i == 2 && chuoi[i].ToString() == "1" && chuoi[i - 1].ToString() != "1" && chuoi[i - 1].ToString() != "0" && LaMotSo(chuoi[i - 1]))
                        tempResult = "mốt ";
                }
                if (chuoi[i] == '0')
                {
                    tempResult = "";
                    if (i == 0 && (chuoi[i + 1] != '0' || chuoi[i + 2] != '0'))
                        tempResult = "không trăm ";
                    if (i == 1 && chuoi[i + 1] != '0')
                        tempResult = "lẻ ";
                }
                result += tempResult;
            }
            if (vitrikitcuoi > 3 && result.Length > 0)
            {
                int vitritam = vitrikitcuoi - 1;
                string solanti = "";
                while (vitritam > 9)
                {
                    vitritam = vitritam - 9;
                    solanti += "tỉ ";
                }
                if (vitritam % 9 == 0) result += "tỉ ";
                else if (vitritam % 6 == 0) result += "triệu ";
                else if (vitritam % 3 == 0) result += "nghìn ";
                result += solanti;
            }
            return result;
        }

        /// <summary>
        /// Thực hiện việc đọc số thành chữ. (Phương thức này chỉ dùng để phục vụ xây dựng phương thức Readnuber)
        /// </summary>
        /// <param name="chuoiso">Chuỗi cần đọc</param>
        /// <returns></returns>
        public static string DocChuoi(string chuoiso)
        {
            string result = "";
            if (chuoiso.Length % 3 == 1)
                chuoiso = "_" + "_" + chuoiso;
            if (chuoiso.Length % 3 == 2)
                chuoiso = "_" + chuoiso;
            string chuoi3so = "";
            int vitrikitucuoi;
            for (int i = 0; i < chuoiso.Length;)
            {
                chuoi3so = chuoiso[i].ToString();
                chuoi3so += chuoiso[i + 1].ToString();
                chuoi3so += chuoiso[i + 2].ToString();
                vitrikitucuoi = chuoiso.Length - (i + 2);
                result += doc3so(chuoi3so, vitrikitucuoi);
                //Tăng i
                i += 3;
            }
            return result;
        }

        #endregion Đọc số thành chữ
    }
}