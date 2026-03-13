using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaodienwin
{
    public enum SpecialStatus { None, NearPoor, Poor }

    public abstract class Household
    {
        public string Address { get; set; }
        public string HeadId { get; set; }
        public List<string> MemberIds { get; set; }
        public SpecialStatus SpecialStatus { get; set; }

        public Household(string address, string headId, List<string> memberIds, SpecialStatus specialStatus)
        {
            Address = address;
            HeadId = headId;
            MemberIds = memberIds ?? new List<string>();
            SpecialStatus = specialStatus;
        }

        public new abstract string GetType();

        public void Display()
        {
            Console.WriteLine($"Địa chỉ: {Address}, Loại hộ: {GetType()}, Trạng thái đặc biệt: {SpecialStatus}");
        }
    }

    public class PermanentHousehold : Household
    {
        public PermanentHousehold(string address, string headId, List<string> memberIds, SpecialStatus specialStatus)
            : base(address, headId, memberIds, specialStatus) { }

        public override string GetType() => "Permanent";
    }

    public class TemporaryHousehold : Household
    {
        public Date ExpiryDate { get; set; }

        public TemporaryHousehold(string address, string headId, List<string> memberIds, SpecialStatus specialStatus, Date expiryDate)
            : base(address, headId, memberIds, specialStatus)
        {
            ExpiryDate = expiryDate;
        }

        public override string GetType() => "Temporary";

        public Date GetExpiryDate() => ExpiryDate;
    }
}
