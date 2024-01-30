using System.ComponentModel.DataAnnotations;

namespace BlazorPractice.Client.Models;

public class Koji
{
    [Required(ErrorMessage = "工事名は必須入力です")]
    [StringLength(10, ErrorMessage = "工事名は10文字以内で入力してください。")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "フリガナは必須入力です")]
    [StringLength(30, ErrorMessage = "フリガナは30文字以内で入力してください。")]
    public string? Furigana { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime ImplementationDate { get; set; }

    public string? Description { get; set; }
}


// 以下のように、Kojiクラスを定義すると、
// 複雑なタイプがFormに含まれ、Validationがうまくいかない。
//public class Koji
//{
//    public Basic? BasicInfo { get; set; }
//    public Contract? ContractInfo { get; set; }
//    public History? HistoryInfo { get; set; }

//    public class Basic
//    {
//        [Required(ErrorMessage = "工事名は必須入力です")]
//        [StringLength(10, ErrorMessage = "工事名は10文字以内で入力してください。")]
//        public string? Name { get; set; }

//        [Required(ErrorMessage = "フリガナは必須入力です")]
//        [StringLength(30, ErrorMessage = "フリガナは30文字以内で入力してください。")]
//        public string? Furigana { get; set; }
//    }

//    public class Contract
//    {
//        public DateTime OrderDate { get; set; }
//    }

//    public class History
//    {
//        public DateTime ImplementationDate { get; set; }

//        public string? Description { get; set; }
//    }
//}

