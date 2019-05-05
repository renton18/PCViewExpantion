using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCViewExpantion.Model
{
    class PC
    {

        //①【参照設定】System.ComponentModel.DataAnnotations
        //②index使用する場合は「using System.ComponentModel.DataAnnotations.Schema;」を追加（「Ctrl + .」では追加されない)
        //③テーブル名の指定以下クラス名の上に追加　[Table("テーブル名")]
        //④1つの列にユニークインデックス(一意にしたい）を設定したい場合は　[Index(IsUnique = true)]　を使用する

        [Key]
        public int Id { get; set; }

        [DisplayName("画面")]
        public string monitor { get; set; }

        [DisplayName("メインメモリ")]
        public string mainMemory { get; set; }

        [DisplayName("CPU")]
        public string cpu { get; set; }

        [DisplayName("ユーザ名")]
        public string userName { get; set; }

        [DisplayName("PC名")]
        public string computerName { get; set; }

        [DisplayName("ホスト名")]
        public string hostName { get; set; }

        [DisplayName("ドメイン")]
        public string domainName { get; set; }

        [DisplayName("ワークグループ")]
        public string workGroup { get; set; }

        [DisplayName("PC説明")]
        public string pcExplain { get; set; }

        [DisplayName("DNS1")]
        public string primaryDNS { get; set; }

        [DisplayName("DNS2")]
        public string seconderyDNS { get; set; }



        [DisplayName("作成日時")]
        public DateTime createdDate { get; set; }

    }
}
