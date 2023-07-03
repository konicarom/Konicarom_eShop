using System.Data.SqlClient;
using System.Data;


namespace eShop.Web.Controls
{
    public class DataAccess
    {
        string connectstring = "Data Source = localhost; Initial Catalog=eShop; Integrated Security=True";
        SqlConnection cn;
        SqlDataAdapter da;
        DataTable dt;
        void KetNoiCSDL()
        {
            cn = new SqlConnection(connectstring);
            cn.Open();
        }

        void NgatKetNoi()
        {
            cn.Close();
            cn.Dispose();
        }
        public DataTable LayDuLieu(string TenSP) //TenSP: tên store Procedure liên quan đến thao tác
                                                 //Ví dụ: muốn lấy dữ liệu bảng hàng hóa: chọn nút hiển thị -> gọi đến SP Select_HangHoa trong store Procedure
        {
            KetNoiCSDL();
            SqlCommand cmd = new SqlCommand(TenSP, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd); //sử dụng da để chuyển đổi dữ liệu
            dt = new DataTable();
            da.Fill(dt);
            NgatKetNoi();
            return dt;
            //khi sử dụng Insert, Delete, Update thì khai báo thêm SQLCommand để sử dụng			
        }
        public int Thuchien_HanhDong(string TenSP, string[] name, object[] value, int NPara) //Tên SP:
                                                                                             //mảng name: chứa danh sách tên các tham số
                                                                                             //mảng value chứa danh sách giá trị các tham số
                                                                                             //NPara: số tham số
        {
            KetNoiCSDL();
            SqlCommand cmd = new SqlCommand(TenSP, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < NPara; i++)
            {
                cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }

        public DataTable LayDuLieu_CoDK(string TenSP, string[] name, object[] value, int NPara)
        {
            KetNoiCSDL();
            SqlCommand cmd = new SqlCommand(TenSP, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < NPara; i++)
            {
                // if (TenSP == name[i])
                // {
                cmd.Parameters.AddWithValue(name[i], value[i]);
                // }
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
