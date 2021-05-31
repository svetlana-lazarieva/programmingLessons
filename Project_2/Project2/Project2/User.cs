using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2
{
    [Table("Users")]
    public class User : TableBase
    {
        [NotMapped]
        public override int Id => UserId;
        [Key]
        public int UserId { get; set; }
        public string userName { get; set; }
        public string userAddress { get; set; }
        public int userType { get; set; }
        public string password { get; set; }

        public override void Copy(TableBase otherTable)
        {
            PropertyCopier<User, User>.Copy(otherTable as User, this);
        }
    }
}