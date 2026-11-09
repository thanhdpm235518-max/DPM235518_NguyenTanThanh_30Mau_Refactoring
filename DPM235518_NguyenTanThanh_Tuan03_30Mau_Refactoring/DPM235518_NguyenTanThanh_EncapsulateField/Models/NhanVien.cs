namespace DPM235518_NguyenTanThanh_EncapsulateField.Models
{
    // Mô hình cho bài toán Encapsulate Field
    public class NhanVien
    {
        public string TenNhanVien { get; set; }
        // Biến public này đang vi phạm quy tắc Encapsulate Field
        public double LuongCoBan; 
    }
}
