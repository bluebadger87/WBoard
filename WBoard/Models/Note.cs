using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WBoard.Models
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; } //글번호

        public int NoteWriter { get; set; } //글작성자

        [Required]
        public string NoteTitle { get; set; } //글제목

        [Required]
        public string NoteContent { get; set; } //글내용

        public string NoteFileName { get; set; } //글파일명

        public int NoteFileSize { get; set; } //글파일크기

        public int NoteReadCount { get; set; } //글조회수

        public int NoteLikeCount { get; set; } //글좋아요

        public int NoteCommentCount { get; set; } //댓글수

        public string NoteCategory { get; set; } //글카테고리(확장)

        public string NoteRemark { get; set; } //글비고(확장)

        public DateTime NoteInsDate { get; set; } //글작성일

        public DateTime NoteUpdDate { get; set; } //글수정일

        public Boolean NoteDel { get; set; } //글삭제여부
    }
}
