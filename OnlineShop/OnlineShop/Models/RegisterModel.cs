using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
    public class RegisterModel
    {
        [Key]
        public long ID { set; get; }
        [Required(ErrorMessage ="Username is required!")]
        public string UserName { set; get; }
        [Required(ErrorMessage = "Password is required!")]
        [StringLength(maximumLength:20,MinimumLength =6,ErrorMessage ="Độ dài ít nhất là 6")]
        public string Password { set; get; }
        [Required(ErrorMessage = "Confirm password is required!")]
        [Compare("Password", ErrorMessage = "Xác nhận mật khẩu không đúng")]
        public string ConfirmPassword { set; get; }
        [Required(ErrorMessage = "Name is required!")]
        public string Name { set; get; }
        [Required(ErrorMessage = "Address is required!")]
        public string Address { set; get; }
        public string Email { set; get; }
        [Display(Name="Phone number")]
        [Required(ErrorMessage = "Phone number is required!")]
        public string Phone { set; get; }
        [Display(Name="Tỉnh/Thành")]
        public string ProvinceID { set; get; }
        [Display(Name="Quận/Huyện")]
        public string DistrictID { set; get; }
        [Required(ErrorMessage = "Captcha number is required!")]
        public string CaptchaCode { get; set; }
    }
}