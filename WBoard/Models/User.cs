using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WBoard.Models
{
    public class User
    {

        public int UserId { get; set; } //유저번호
        
        [Required]
        public string UserLoginId { get; set; } //유저로그인아이디

        [Required, DataType(DataType.Password)]
        [StringLength(20, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 4)]
        public string UserPassword1 { get; set; } //유저로그인비번

        [Required, DataType(DataType.Password)]
        [Compare("UserPassword1", ErrorMessage = "Password doesn't match.")] 
        public string UserPassword2 { get; set; } //유저로그인비번확인용

        public string UserNickName { get; set; } //유저닉네임

        [Required]
        public string UserName { get; set; } //유저네임

        public string UserPostcode { get; set; } //유저우편번호

        public string UserAddress1 { get; set; } //유저주소1

        public string UserAddress2 { get; set; } //유저주소2

        public string UserTel { get; set; } //유저연락처

        [Required, EmailAddress]
        public string UserEmail { get; set; } //유저이메일

        public string UserRemark { get; set; } //유저비고

        public int UserRole { get; set; } //유저자격

        public Boolean UserLock { get; set; } //유저잠금

        public DateTime UserInsDate { get; set; } //유저작성일

        public DateTime UserUpdDate { get; set; } //유저수정일

        public Boolean UserDel { get; set; } //유저삭제여부
    }
}
