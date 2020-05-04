using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OtakuAssetManagement.Models
{
    [MetadataType(typeof(AssetMetaData))]
    public partial class M_Asset
    {

    }

    public class AssetMetaData
    {
        [Display(Name = "資産番号")]
        [Required(ErrorMessage = "{0} は必須入力です")]
        public object AssetNo { get; set; }

        [Display(Name = "資産名称")]
        [Required(ErrorMessage = "{0} は必須入力です")]
        public object AssetName { get; set; }

        [Display(Name = "用途")]
        [Required(ErrorMessage = "{0} は必須入力です")]
        public object UseCategory { get; set; }

        [Display(Name = "数量")]
        [Required(ErrorMessage = "{0} は必須入力です")]
        public object Amount { get; set; }

        [Display(Name = "状態")]
        [Required(ErrorMessage = "{0} は必須入力です")]
        public object Status { get; set; }

        [Display(Name = "取得日")]
        [Required(ErrorMessage = "{0} は必須入力です")]
        public object GetDate { get; set; }

        [Display(Name = "取得理由")]
        [Required(ErrorMessage = "{0} は必須入力です")]
        public object GetReason { get; set; }

        [Display(Name = "異動日")]
        public object TransferDate { get; set; }

        [Display(Name = "異動理由")]
        public object TransferReason { get; set; }

        [Display(Name = "所属ID")]
        [Required(ErrorMessage = "{0} は必須入力です")]
        public object BelongingID { get; set; }

        [Display(Name = "場所ID")]
        [Required(ErrorMessage = "{0} は必須入力です")]
        public object PlaceID { get; set; }

        [Display(Name = "登録日")]
        [Required(ErrorMessage = "{0} は必須入力です")]
        public object InsertDate { get; set; }

        [Display(Name = "更新日")]
        public object UpdateDate { get; set; }
    }
}