using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaodienwin
{


    public class HouseholdManager
    {
        private List<Household> households;
        private Dictionary<string, HouseholdHead> heads;
        private Dictionary<string, FamilyMember> familyMembers;

        public HouseholdManager()
        {
            households = new List<Household>();
            heads = new Dictionary<string, HouseholdHead>();
            familyMembers = new Dictionary<string, FamilyMember>();
        }

        public bool IsAddressUnique(string addr)
        {
            return !households.Any(h => h.Address == addr);
        }

        public HouseholdHead GetHead(string id)
        {
            return heads.ContainsKey(id) ? heads[id] : null;
        }

        public FamilyMember GetMember(string id)
        {
            return familyMembers.ContainsKey(id) ? familyMembers[id] : null;
        }

        public void AddHousehold(Household household, HouseholdHead head, List<FamilyMember> members)
        {
            if (!IsAddressUnique(household.Address))
                throw new Exception($"Địa chỉ {household.Address} đã tồn tại!");
            if (heads.ContainsKey(head.Id) || familyMembers.ContainsKey(head.Id))
                throw new Exception($"ID chủ hộ {head.Id} đã tồn tại!");

            heads[head.Id] = head;
            households.Add(household);
        }

        public void EditHousehold(string searchTerm, string newAddress, SpecialStatus newStatus, Date newExpiryDate = null)
        {
            var household = households.FirstOrDefault(h => h.Address == searchTerm || h.HeadId == searchTerm);
            if (household == null)
                throw new Exception($"Không tìm thấy hộ dân với địa chỉ hoặc ID: {searchTerm}");

            if (household.Address != newAddress && !IsAddressUnique(newAddress))
                throw new Exception($"Địa chỉ mới {newAddress} đã tồn tại!");

            household.Address = newAddress;
            household.SpecialStatus = newStatus;
            if (household is TemporaryHousehold temp)
                temp.ExpiryDate = newExpiryDate ?? temp.ExpiryDate;
        }

        public void DeleteHousehold(string searchTerm)
        {
            var household = households.FirstOrDefault(h => h.Address == searchTerm || h.HeadId == searchTerm);
            if (household == null)
                throw new Exception($"Không tìm thấy hộ dân với địa chỉ hoặc ID: {searchTerm}");

            heads.Remove(household.HeadId);
            households.Remove(household);
        }

        public List<Household> SearchByAddress(string addr)
        {
            return households.Where(h => h.Address == addr).ToList();
        }

        public List<Household> SearchById(string id)
        {
            return households.Where(h => h.HeadId == id || h.MemberIds.Contains(id)).ToList();
        }

        public List<Household> FindExpiredTemporaryHouseholds()
        {
            return households
                .Where(h => h.GetType() == "Temporary" && (h as TemporaryHousehold).GetExpiryDate().IsExpired())
                .ToList();
        }

        public List<Household> GetAllHouseholds()
        {
            return households;
        }

        public void AddMemberToHousehold(string searchTerm, string memberId)
        {
            var household = households.FirstOrDefault(h => h.Address == searchTerm || h.HeadId == searchTerm);
            if (household == null)
                throw new Exception($"Không tìm thấy hộ dân với địa chỉ hoặc ID: {searchTerm}");

            if (heads.ContainsKey(memberId))
                throw new Exception($"ID thành viên {memberId} đã tồn tại trong danh sách chủ hộ!");
            if (!familyMembers.ContainsKey(memberId))
                throw new Exception($"ID thành viên {memberId} không tồn tại! Vui lòng thêm thành viên trước.");

            var member = familyMembers[memberId];
            if (member.HeadId != household.HeadId)
                throw new Exception($"ID chủ hộ của thành viên ({member.HeadId}) không khớp với chủ hộ ({household.HeadId})!");

            household.MemberIds.Add(memberId);
        }

        public void AddPerson(FamilyMember member)
        {
            if (familyMembers.ContainsKey(member.Id))
                throw new Exception($"ID người dân {member.Id} đã tồn tại!");
            familyMembers[member.Id] = member;
        }

        internal void LoadFromCsv(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
