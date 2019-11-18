using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WBoard.Models
{
    public class NoteComment
    {
        public int NoteCommentId { get; set; } //댓글번호

        public int NoteCommentNoteId { get; set; } //현재글번호

        public int NoteCommentWriter { get; set; } //댓글작성자

        [Required]
        public string NoteCommentOpinion { get; set; } //댓글내용

        public string NoteCommentFileName { get; set; } //댓글파일명

        public int NoteCommentFileSize { get; set; } //댓글파일명

        public string NoteCommentRemark { get; set; } //댓글비고(확장)

        public int NoteCommentParentOp { get; set; } //부모댓글

        public DateTime NoteCommentInsDate { get; set; } //댓글작성일

        public DateTime NoteCommentUpdDate { get; set; } //댓글수정일

        public Boolean NoteCommentDel { get; set; } //댓글삭제여부
    }
}
