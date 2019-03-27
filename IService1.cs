using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Mlmservices
{

    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "json/Login")]
        IList<string> JSONLogin(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "json/ChangePassword")]
        IList<string> JSONChangePassword(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "json/GetFlatNo")]
        IList<string> JSONGetFlatNo(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "json/GetFlatDetails")]
        IList<string> JSONGetFlatDetails(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "json/GetMemberName")]
        IList<string> JSONGetMemberName(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
          ResponseFormat = WebMessageFormat.Json,
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "json/GetUploadedDocument")]
        IList<string> JSONGetUploadedDocument(MyFlat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "json/GetVehicleInfo")]
        IList<string> JSONGetVehicleInfo(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
          ResponseFormat = WebMessageFormat.Json,
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "json/VisitorCount")]
        IList<string> JSONVisitorCount(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "json/VisitorCount1")]
        IList<string> JSONVisitorCount1(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "json/StaffInfo")]
        IList<string> JSONStaffInfo(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "json/ShowStaffDetails")]
        IList<string> JSONShowStaffDetails(HelpersManagement m);

        [OperationContract]
        [WebInvoke(Method = "POST",
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "json/ShowStaffDetails1")]
        IList<string> JSONShowStaffDetails1(HelpersManagement m);

        [OperationContract]
        [WebInvoke(Method = "POST",
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "json/ShowStaffDetails2")]
        IList<string> JSONShowStaffDetails2(HelpersManagement m);

        [OperationContract]
        [WebInvoke(Method = "POST",
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "json/AddNewMember")]
        IList<string> JSONAddNewMember(MyFlat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/GetPersonalInfo")]
        IList<string> JSONGetPersonalInfo(MyFlat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "json/GetFlatNo2")]
        IList<string> JSONGetFlatNo2(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "json/VisitorEntry")]
        IList<string> JSONVisitorEntry(VisitorEntry m);

        [OperationContract]
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "json/AddVehicle")]
        IList<string> JSONAddVehicle(Vehicle m);

        [OperationContract]
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "json/ShowNoticeType")]
        IList<string> JSONShowNoticeType(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
          ResponseFormat = WebMessageFormat.Json,
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "json/DiviedPostNoticeType")]
        IList<string> JSONDiviedPostNoticeType(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
          ResponseFormat = WebMessageFormat.Json,
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "json/ShowNoticeBeingEdited")]
        IList<string> JSONShowNoticeBeingEdited(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
          ResponseFormat = WebMessageFormat.Json,
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "json/ShowExpiryNotice")]
        IList<string> JSONShowExpiryNotice(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
          ResponseFormat = WebMessageFormat.Json,
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "json/ShowExpiryNotice1")]
        IList<string> JSONShowExpiryNotice1(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
          ResponseFormat = WebMessageFormat.Json,
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "json/ShowExpiryNotice2")]
        IList<string> JSONShowExpiryNotice2(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
          ResponseFormat = WebMessageFormat.Json,
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "json/CreateNotice")]
        IList<string> JSONCreateNotice(Notice m);

        [OperationContract]
        [WebInvoke(Method = "POST",
          ResponseFormat = WebMessageFormat.Json,
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "json/MyFriends")]
        IList<string> JSONMyFriends(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
          ResponseFormat = WebMessageFormat.Json,
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "json/CreateGroupChat")]
        IList<string> JSONCreateGroupChat(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "json/JoinGroupChat")]
        IList<string> JSONJoinGroupChat(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "json/GetJoinGroupInfo")]
        IList<string> JSONGetJoinGroupInfo(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "json/RequestforJoinGroup")]
        IList<string> JSONRequestforJoinGroup(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "json/ShowAllMemberAddInGroup")]
        IList<string> JSONShowAllMemberAddInGroup(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/SearchGroupMember")]
        IList<string> JSONSearchGroupMember(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ViewAndEMail")]
        IList<string> JSONViewAndEMail(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ShowingGroupCreaterInfo")]
        IList<string> JSONShowingGroupCreaterInfo(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/RequestForApprovingGroup")]
        IList<string> JSONRequestForApprovingGroup(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/NoticeDetailedOnComment")]
        IList<string> JSONNoticeDetailedOnComment(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/CommentOnNotice")]
        IList<string> JSONCommentOnNotice(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ShowCommentOnNotice")]
        IList<string> JSONShowCommentOnNotice(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ViewGroupsBlock")]
        IList<string> JSONViewGroupsBlock(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ViewGroupsBlock1")]
        IList<string> JSONViewGroupsBlock1(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/SelectBlockForMember")]
        IList<string> JSONSelectBlockForMember(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/AddMemberInGroup")]
        IList<string> JSONAddMemberInGroup(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ShowGroupInfoInEdit")]
        IList<string> JSONShowGroupInfoInEdit(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/EditGroupInfo")]
        IList<string> JSONEditGroupInfo(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ShowALLGroupMembersToRemove")]
        IList<string> JSONShowALLGroupMembersToRemove(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ShowALLGroupMembersToRemove1")]
        IList<string> JSONShowALLGroupMembersToRemove1(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/RemoveMembersFromGroup")]
        IList<string> JSONRemoveMembersFromGroup(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ApproveMembers")]
        IList<string> JSONApproveMembers(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ApproveMembers1")]
        IList<string> JSONApproveMembers1(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ApprovingMembers")]
        IList<string> JSONApprovingMembers(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/DeclineMembers")]
        IList<string> JSONDeclineMembers(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ShowAllMemberAddedInGroup")]
        IList<string> JSONShowAllMemberAddedInGroup(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ShowAllMemberAddedInGroup1")]
        IList<string> JSONShowAllMemberAddedInGroup1(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/SearchMembersOfGroup")]
        IList<string> JSONSearchMembersOfGroup(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ViewEmail")]
        IList<string> JSONViewEmail(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/BindGroupInfoInEdit")]
        IList<string> JSONBindGroupInfoInEdit(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/EditGroupSaveData")]
        IList<string> JSONEditGroupSaveData(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/BindGroupsDetailsForAddMember")]
        IList<string> JSONBindGroupsDetailsForAddMember(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/BindGroupsDetailsForAddMember1")]
        IList<string> JSONBindGroupsDetailsForAddMember1(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ShowAllMemberofBlock")]
        IList<string> JSONShowAllMemberofBlock(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/AddMemberToGroup")]
        IList<string> JSONAddMemberToGroup(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/BindALLGroupMembersToRemove")]
        IList<string> JSONBindALLGroupMembersToRemove(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/BindALLGroupMembersToRemove1")]
        IList<string> JSONBindALLGroupMembersToRemove1(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/RemoveMembersApproving")]
        IList<string> JSONRemoveMembersApproving(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ShowGroupCreaterInfo")]
        IList<string> JSONShowGroupCreaterInfo(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ShowAlbumList")]
        IList<string> JSONShowAlbumList(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/CreateAlbum")]
        IList<string> JSONCreateAlbum(Pixar m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/GetAlbumsByID")]
        IList<string> JSONGetAlbumsByID(Pixar m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/GetAlbumsByID1")]
        IList<string> JSONGetAlbumsByID1(Pixar m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/UploadPhotosInAlbums")]
        IList<string> JSONUploadPhotosInAlbums(Pixar m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/GetAlbumDetailsForSlider")]
        IList<string> JSONGetAlbumDetailsForSlider(Pixar m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/GetAlbumDetailsForSlider1")]
        IList<string> JSONGetAlbumDetailsForSlider1(Pixar m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/GetAlbumDetailsForSlider2")]
        IList<string> JSONGetAlbumDetailsForSlider2(Pixar m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/BindAllPoll")]
        IList<string> JSONBindAllPoll(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/BindAllPoll1")]
        IList<string> JSONBindAllPoll1(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/BindAllPoll2")]
        IList<string> JSONBindAllPoll2(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/PollVote")]
        IList<string> JSONPollVote(PollVote m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/RemovePoll")]
        IList<string> JSONRemovePoll(PollVote m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ClosePoll")]
        IList<string> JSONClosePoll(PollVote m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ExtendPoll")]
        IList<string> JSONExtendPoll(PollVote m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/CreatePoll")]
        IList<string> JSONCreatePoll(PollVote m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/BindGroups")]
        IList<string> JSONBindGroups(PollVote m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ManageUserUnapproved")]
        IList<string> JSONManageUserUnapproved(Pixar m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ManageUserApprove")]
        IList<string> JSONManageUserApprove(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ManageUserDeActivate")]
        IList<string> JSONManageUserDeActivate(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ManageUserUnapprovedDelete")]
        IList<string> JSONManageUserUnapprovedDelete(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ManageUserEditGetDetails")]
        IList<string> JSONManageUserEditGetDetails(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ManageUserEditGetDetails1")]
        IList<string> JSONManageUserEditGetDetails1(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ManageUserBindCountry")]
        IList<string> JSONManageUserBindCountry(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ManageUserBindDesignation")]
        IList<string> JSONManageUserBindDesignation(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ManageUserBindState")]
        IList<string> JSONManageUserBindState(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ManageUserBindCity")]
        IList<string> JSONManageUserBindCity(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ManageUserBindAccessLevel")]
        IList<string> JSONManageUserBindAccessLevel(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/UnApprovedEdit")]
        IList<string> JSONUnApprovedEdit(ManageUser m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/AddAuthorityPopulateRoot")]
        IList<string> JSONAddAuthorityPopulateRoot(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/BindLeftTree_Admin")]
        IList<string> JSONBindLeftTree_Admin(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/BindLeftTree_User")]
        IList<string> JSONBindLeftTree_User(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/AboutUsGetImage")]
        IList<string> JSONAboutUsGetImage(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/AboutUsGetHomeProfile")]
        IList<string> JSONAboutUsGetHomeProfile(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/AboutUsGetSocietyLocation")]
        IList<string> JSONAboutUsGetSocietyLocation(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/BrodcastAllMemSubGroup")]
        IList<string> JSONBrodcastAllMemSubGroup(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/BrodcastBindBlocks")]
        IList<string> JSONBrodcastBindBlocks(CreateGroupChat m);

        //[OperationContract]
        //[WebInvoke(Method = "POST",
        //ResponseFormat = WebMessageFormat.Json,
        //RequestFormat = WebMessageFormat.Json,
        //BodyStyle = WebMessageBodyStyle.Bare,
        //UriTemplate = "json/BrodcastSend")]
        //IList<string> JSONBrodcastSend(BroadCast m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/BrodcastSendEmail")]
        IList<string> JSONBrodcastSendEmail(BroadCast m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/BrodcastSendEmail1")]
        IList<string> JSONBrodcastSendEmail1(BroadCast m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/AddUserBindBlocks")]
        IList<string> JSONAddUserBindBlocks(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/AddUserBindAuthorityList")]
        IList<string> JSONAddUserBindAuthorityList(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/AddUserSave")]
        IList<string> JSONAddUserSave(MyFlat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ApproveUserBindBlocks")]
        IList<string> JSONApproveUserBindBlocks(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ApproveUserBindInfo")]
        IList<string> JSONApproveUserBindInfo(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ApprovedSaveEdit")]
        IList<string> JSONApprovedSaveEdit(ManageUser m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/YellowPageBindDetails")]
        IList<string> JSONYellowPageBindDetails(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/YellowPageEditVendor")]
        IList<string> JSONYellowPageEditVendor(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/YellowPageEditSave")]
        IList<string> JSONYellowPageEditSave(YellowPage m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/YellowPageEditDelete")]
        IList<string> JSONYellowPageEditDelete(YellowPage m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/YellowPageAddVendor")]
        IList<string> JSONYellowPageAddVendor(YellowPage m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/YellowPageInviteNeighbour")]
        IList<string> JSONYellowPageInviteNeighbour(BroadCast m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/YellowPageBindManagingCommitee")]
        IList<string> JSONYellowPageBindManagingCommitee(YellowPage m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/BindManagingCommiteeModerator")]
        IList<string> JSONBindManagingCommiteeModerator(YellowPage m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ManagingCommiteeMemberProfile")]
        IList<string> JSONManagingCommiteeMemberProfile(YellowPage m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/YellowPageViewNeighbour")]
        IList<string> JSONYellowPageViewNeighbour(ManageUser m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/GetAdminStatistics")]
        IList<string> JSONGetAdminStatistics(YellowPage m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/GetAdminStatistics1")]
        IList<string> JSONGetAdminStatistics1(YellowPage m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/GetFlatNumber")]
        IList<string> JSONGetFlatNumber(PollVote m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/HelpGetCategory")]
        IList<string> JSONHelpGetCategory(YellowPage m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/HelpGetSubCategory")]
        IList<string> JSONHelpGetSubCategory(Pixar m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/HelpSaveRaiseTicket")]
        IList<string> JSONHelpSaveRaiseTicket(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/GetPersonalOpenTickets")]
        IList<string> JSONGetPersonalOpenTickets(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/GetAdvertiseDetails")]
        IList<string> JSONGetAdvertiseDetails(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/GetCommunityOpenTickets")]
        IList<string> JSONGetCommunityOpenTickets(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/GetOpenTicketsDetails")]
        IList<string> JSONGetOpenTicketsDetails(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/GetOpenTicketsNotes")]
        IList<string> JSONGetOpenTicketsNotes(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/OpenTicketsAddNotes")]
        IList<string> JSONOpenTicketsAddNotes(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/GetCommunityOpenTicket")]
        IList<string> JSONGetCommunityOpenTicket(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/GetBindDetails")]
        IList<string> JSONGetBindDetails(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/GetBindCategory")]
        IList<string> JSONGetBindCategory(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/GetBindServiced")]
        IList<string> JSONGetBindServiced(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/GetBindFlatNo")]
        IList<string> JSONGetBindFlatNo(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/GetBindFilter")]
        IList<string> JSONGetBindFilter(OpenTickets m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/GetCommunityClosedTicket")]
        IList<string> JSONGetCommunityClosedTicket(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/BindClosedTicketDetails")]
        IList<string> JSONBindClosedTicketDetails(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ReopenClosedTickets")]
        IList<string> JSONReopenClosedTickets(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/BindClosedTicketsNotes")]
        IList<string> JSONBindClosedTicketsNotes(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/EventCalenderCurrentActivity")]
        IList<string> JSONEventCalenderCurrentActivity(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/EventCalenderUpComingActivity")]
        IList<string> JSONEventCalenderUpComingActivity(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/EventCalenderAttendingActivity")]
        IList<string> JSONEventCalenderAttendingActivity(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/EventCalenderMayAttendActivity")]
        IList<string> JSONEventCalenderMayAttendActivity(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/GetCurrentActivityByID")]
        IList<string> JSONGetCurrentActivityByID(YellowPage m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/GetCurrentActivityByID1")]
        IList<string> JSONGetCurrentActivityByID1(YellowPage m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ActivityStatus")]
        IList<string> JSONActivityStatus(YellowPage m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ActivityBindBlock")]
        IList<string> JSONActivityBindBlock(YellowPage m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/GetSelectedBlockMember")]
        IList<string> JSONGetSelectedBlockMember(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/AddMemberActivity")]
        IList<string> JSONAddMemberActivity(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/GetAddedMemberActivity")]
        IList<string> JSONGetAddedMemberActivity(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/RemoveMemberFromActivity")]
        IList<string> JSONRemoveMemberFromActivity(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/SuggestAnEvent")]
        IList<string> JSONSuggestAnEvent(EventCalender m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/AssetInvolved")]
        IList<string> JSONAssetInvolved(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/EditHelpdesk")]
        IList<string> JSONEditHelpdesk(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/RaiseaTicket")]
        IList<string> JSONRaiseaTicket(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/CreateMeeting")]
        IList<string> JSONCreateMeeting(CreateMeeting m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/OpenMeeting")]
        IList<string> JSONOpenMeeting(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/EditaMeeting")]
        IList<string> JSONEditaMeeting(CreateMeeting m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ListClosedMeeting")]
        IList<string> JSONListClosedMeeting(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
      ResponseFormat = WebMessageFormat.Json,
      RequestFormat = WebMessageFormat.Json,
      BodyStyle = WebMessageBodyStyle.Bare,
      UriTemplate = "json/UnApprovalNoticeOnLoad")]
        IList<string> JSONUnApprovalNoticeOnLoad(HelpDesk m);


        [OperationContract]
        [WebInvoke(Method = "POST",
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "json/UnApprovalEditeNoticeForApproval")]
        IList<string> JSONUnApprovalEditeNoticeForApproval(HelpDesk m);


        [OperationContract]
        [WebInvoke(Method = "POST",
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "json/UnApprovalViewcommand")]
        IList<string> JSONUnApprovalViewcommand(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "json/UnApprovalNoticeApprove")]
        IList<string> JSONUnApprovalNoticeApprove(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "json/UnApprovalNoticeDeactive")]
        IList<string> JSONUnApprovalNoticeDeactive(HelpDesk m);




        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/SaveNotice")]
        IList<string> JSONSaveNotice(Notice m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/UserPersonal")]
        IList<string> JSONUserPersonal(MyFlat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/BindUserFlatInfo1")]
        IList<string> JSONBindUserFlatInfo1(MyFlat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/BindUserFlatInfo2")]
        IList<string> JSONBindUserFlatInfo2(MyFlat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/BindUserFlatInfo3")]
        IList<string> JSONBindUserFlatInfo3(MyFlat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/BindUserFlatInfo4")]
        IList<string> JSONBindUserFlatInfo4(MyFlat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/MakePrimaryContact")]
        IList<string> JSONMakePrimaryContact(MyFlat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/MeetingAgenda")]
        IList<string> JSONMeetingAgenda(CreateMeeting m);

        [OperationContract]
        [WebInvoke(Method = "POST",
      ResponseFormat = WebMessageFormat.Json,
      RequestFormat = WebMessageFormat.Json,
      BodyStyle = WebMessageBodyStyle.Bare,
      UriTemplate = "json/MeetingAttendees")]
        IList<string> JSONMeetingAttendees(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
      ResponseFormat = WebMessageFormat.Json,
      RequestFormat = WebMessageFormat.Json,
      BodyStyle = WebMessageBodyStyle.Bare,
      UriTemplate = "json/BindOfficeStaff")]
        IList<string> JSONBindOfficeStaff(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
      ResponseFormat = WebMessageFormat.Json,
      RequestFormat = WebMessageFormat.Json,
      BodyStyle = WebMessageBodyStyle.Bare,
      UriTemplate = "json/CreateIssue")]
        IList<string> JSONCreateIssue(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
      ResponseFormat = WebMessageFormat.Json,
      RequestFormat = WebMessageFormat.Json,
      BodyStyle = WebMessageBodyStyle.Bare,
      UriTemplate = "json/OpenSearch")]
        IList<string> JSONOpenSearch(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
     ResponseFormat = WebMessageFormat.Json,
     RequestFormat = WebMessageFormat.Json,
     BodyStyle = WebMessageBodyStyle.Bare,
     UriTemplate = "json/CloseSearch")]
        IList<string> JSONCloseSearch(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
     ResponseFormat = WebMessageFormat.Json,
     RequestFormat = WebMessageFormat.Json,
     BodyStyle = WebMessageBodyStyle.Bare,
     UriTemplate = "json/TicketManamgementOpenTicketSearch")]
        IList<string> JSONTicketManamgementOpenTicketSearch(HelpDesk m);
         
        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/Active_BindMemberNotice")]
        IList<string> JSONActive_BindMemberNotice(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/Active_BindNonMemberNotice")]
        IList<string> JSONActive_BindNonMemberNotice(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/Active_DeleteMemberNotice")]
        IList<string> JSONActive_DeleteMemberNotice(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/Active_ViewMemberNotice")]
        IList<string> JSONActive_ViewMemberNotice(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/Active_BindEditExpiry")]
        IList<string> JSONActive_BindEditExpiry(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/Active_EditExpiryDate")]
        IList<string> JSONActive_EditExpiryDate(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/FacilityBooking_ShowAllFacility")]
        IList<string> JSONFacilityBooking_ShowAllFacility(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/FacilityBooking_FindFacilityType")]
        IList<string> JSONFacilityBooking_FindFacilityType(OpenTickets m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/FacilityBooking_BindFacilityDetails")]
        IList<string> JSONFacilityBooking_BindFacilityDetails(OpenTickets m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/DigitalLibrary_BindFolders")]
        IList<string> JSONDigitalLibrary_BindFolders(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/DigitalLibrary_BindFoldersDetails")]
        IList<string> JSONDigitalLibrary_BindFoldersDetails(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/BrodcastSendFlash")]
        IList<string> JSONBrodcastSendFlash(BroadCast m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/DigitalLibrary_SearchFolders")]
        IList<string> JSONDigitalLibrary_SearchFolders(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/DigitalLibrary_RenameFolders")]
        IList<string> JSONDigitalLibrary_RenameFolders(DigitalLibrary m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/DigitalLibrary_ShowListOfFolders")]
        IList<string> JSONDigitalLibrary_ShowListOfFolders(DigitalLibrary m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/DigitalLibrary_AddDocumentUpload")]
        IList<string> JSONDigitalLibrary_AddDocumentUpload(DigitalLibrary m);


        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/DigitalLibrary_BindEditDocument")]
        IList<string> JSONDigitalLibrary_BindEditDocument(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/DigitalLibrary_BindDropDownList")]
        IList<string> JSONDigitalLibrary_BindDropDownList(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ClosedTickets_BindTicketDetails")]
        IList<string> JSONClosedTickets_BindTicketDetails(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ClosedTickets_GetBindFilter")]
        IList<string> JSONClosedTickets_GetBindFilter(OpenTickets m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ClosedTickets_GetSearchData")]
        IList<string> JSONClosedTickets_GetSearchData(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ClosedTickets_GetUserDetails")]
        IList<string> JSONClosedTickets_GetUserDetails(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/HelpersManagement_BindData")]
        IList<string> JSONHelpersManagement_BindData(CreateGroupChat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/HelpersManagement_SearchData")]
        IList<string> JSONHelpersManagement_SearchData(HelpersManagement m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/HelpersManagement_AddStaff")]
        IList<string> JSONHelpersManagement_AddStaff(HelpersManagement m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/HelpersMngt_EditStaffBindDetails")]
        IList<string> JSONHelpersMngt_EditStaffBindDetails(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/HelpersMngt_EditStaffBindDdl")]
        IList<string> JSONHelpersMngt_EditStaffBindDdl(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/HelpersMngt_UpdateStaffDetails")]
        IList<string> JSONHelpersMngt_UpdateStaffDetails(HelpersManagement m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/HelpersManagement_SearchDataTemp")]
        IList<string> JSONHelpersManagement_SearchDataTemp(HelpersManagement m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/HelpersManagement_SearchDataRetired")]
        IList<string> JSONHelpersManagement_SearchDataRetired(HelpersManagement m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ForgotPassword")]
        IList<string> JSONForgotPassword(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/MyChat_BindDataPoll")]
        IList<string> JSONMyChat_BindDataPoll(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/MyChat_BindDataPollVote")]
        IList<string> JSONMyChat_BindDataPollVote(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/MyChat_BindDataPollVoteOption")]
        IList<string> JSONMyChat_BindDataPollVoteOption(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/MyChat_BindDataPost")]
        IList<string> JSONMyChat_BindDataPost(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/MyChat_BindDataPostLikes")]
        IList<string> JSONMyChat_BindDataPostLikes(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/MyChat_GetUserProfile")]
        IList<string> JSONMyChat_GetUserProfile(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/MyChat_GetVoteResultCount1")]
        IList<string> JSONMyChat_GetVoteResultCount1(PollVote m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/MyChat_GetVoteResultCount2")]
        IList<string> JSONMyChat_GetVoteResultCount2(PollVote m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/MyChat_GetVoteResultCount3")]
        IList<string> JSONMyChat_GetVoteResultCount3(PollVote m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/MyChat_LikePost")]
        IList<string> JSONMyChat_LikePost(DigitalLibrary m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/MyChat_MyPost")]
        IList<string> JSONMyChat_MyPost(Mychat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/HomeServices_BindData")]
        IList<string> JSONHomeServices_BindData(DigitalLibrary m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/ServicePartners_BindData")]
        IList<string> JSONServicePartners_BindData(DigitalLibrary m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/MyAds_BindCategory")]
        IList<string> JSONMyAds_BindCategory(DigitalLibrary m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/MyAds_BindCity")]
        IList<string> JSONMyAds_BindCity(DigitalLibrary m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/MyAds_BindType")]
        IList<string> JSONMyAds_BindType(DigitalLibrary m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/MyAds_BindData")]
        IList<string> JSONMyAds_BindData(OpenTickets m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/MyAds_BindDetails")]
        IList<string> JSONMyAds_BindDetails(Mychat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/MyAds_AddNewAds")]
        IList<string> JSONMyAds_AddNewAds(MyAds m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/MyAds_EditAds")]
        IList<string> JSONMyAds_EditAds(Mychat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/MyAds_UpdateAds")]
        IList<string> JSONMyAds_UpdateAds(MyAds m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/HomeServices_BindSubServices")]
        IList<string> JSONHomeServices_BindSubServices(MyAds m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/HomeServices_ServiceConfirmBooking")]
        IList<string> JSONHomeServices_ServiceConfirmBooking(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/HomeServices_ServiceConfirmBooking1")]
        IList<string> JSONHomeServices_ServiceConfirmBooking1(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/HomeServices_ServiceConfirmBooking2")]
        IList<string> JSONHomeServices_ServiceConfirmBooking2(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/HomeServices_ConfirmBooking")]
        IList<string> JSONHomeServices_ConfirmBooking(Market360 m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/NoticeManagement_CategoryBindDtls")]
        IList<string> JSONNoticeManagement_CategoryBindDtls(Market360 m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/NoticeManagement_DeleteCategory")]
        IList<string> JSONNoticeManagement_DeleteCategory(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/NoticeManagement_ViewCategory")]
        IList<string> JSONNoticeManagement_ViewCategory(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/NoticeManagement_BindMailDtls")]
        IList<string> JSONNoticeManagement_BindMailDtls(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/NoticeManagement_SendMail")]
        IList<string> JSONNoticeManagement_SendMail(Market360 m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/NoticeManagement_BindCategory")]
        IList<string> JSONNoticeManagement_BindCategory(Market360 m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/NoticeManagement_SaveCategoryNotice")]
        IList<string> JSONNoticeManagement_SaveCategoryNotice(HelpDesk m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/MessageNeighbour")]
        IList<string> JSONMessageNeighbour(Market360 m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/MessageNeighbour_GetChat")]
        IList<string> JSONMessageNeighbour_GetChat(Market360 m);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "json/HelpersMngt_BindStaffList")]
        IList<string> JSONHelpersMngt_BindStaffList(CreateGroupChat m);


        [OperationContract]
        [WebInvoke(Method = "POST",
      ResponseFormat = WebMessageFormat.Json,
      RequestFormat = WebMessageFormat.Json,
      BodyStyle = WebMessageBodyStyle.Bare,
      UriTemplate = "json/imageupload")]
        IList<string> JSONimageupload(image i);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/Getimage")]
        IList<string> JSONGetimage(image i);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/OpenTicket_GetUserdetails")]
        IList<string> JSONOpenTicket_GetUserdetails(ManageUser m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/OpenTicket_SendMail")]
        IList<string> JSONOpenTicket_SendMail(BroadCast m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/DigitalLibrary_SocietyOfficeFiledtls")]
        IList<string> JSONDigitalLibrary_SocietyOfficeFiledtls(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/MySweetHome_AddFlatUser")]
        IList<string> JSONMySweetHome_AddFlatUser(MyFlat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/BookService_ServiceCategory")]
        IList<string> JSONBookService_ServiceCategory(MyAds m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/BookService_BindCity")]
        IList<string> JSONBookService_BindCity(MyAds m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/MySweetHome_FeedBack")]
        IList<string> JSONMySweetHome_FeedBack(MyFlat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/UpdateParkingAllotment")]
        IList<string> JSONMyUpdateParkingAllotment(Vehicle m);

       
        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/CalcAdvanceAmt")]
        IList<string> JSONCalcAdvanceAmt(MyFlatDashBoard m);


        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/RefundableDeposit")]
        IList<string> JSONRefundableDeposit(MyFlatDashBoard m);
         

        [OperationContract]
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "json/GetDueDetailsOfMember")]
        IList<string> JSONGetDueDetailsOfMember(LoginModel m);


        [OperationContract]
        [WebInvoke(Method = "POST",
      ResponseFormat = WebMessageFormat.Json,
      RequestFormat = WebMessageFormat.Json,
      BodyStyle = WebMessageBodyStyle.Bare,
      UriTemplate = "json/Pendingbillamt")]
        IList<string> JSONPendingbillamt(MyFlatDashBoard m);


        [OperationContract]
        [WebInvoke(Method = "POST",
      ResponseFormat = WebMessageFormat.Json,
      RequestFormat = WebMessageFormat.Json,
      BodyStyle = WebMessageBodyStyle.Bare,
      UriTemplate = "json/CurrentDue")]
        IList<string> JSONCurrentDue(MyFlatDashBoard m);


        [OperationContract]
        [WebInvoke(Method = "POST",
     ResponseFormat = WebMessageFormat.Json,
     RequestFormat = WebMessageFormat.Json,
     BodyStyle = WebMessageBodyStyle.Bare,
     UriTemplate = "json/History")]
        IList<string> JSONHistory(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
     ResponseFormat = WebMessageFormat.Json,
     RequestFormat = WebMessageFormat.Json,
     BodyStyle = WebMessageBodyStyle.Bare,
     UriTemplate = "json/FullAccountStatement")]
        IList<string> JSONFullAccountStatement(MyFlatDashBoard m); 


        [OperationContract]
        [WebInvoke(Method = "POST",
     ResponseFormat = WebMessageFormat.Json,
     RequestFormat = WebMessageFormat.Json,
     BodyStyle = WebMessageBodyStyle.Bare,
     UriTemplate = "json/DepositReversed")]
        IList<string> JSONDepositReversed(MyFlatDashBoard m);


        [OperationContract]
        [WebInvoke(Method = "POST",
    ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare,
    UriTemplate = "json/ReserveMemberReceiptBill")]
        IList<string> JSONReserveMemberReceiptBill(MyFlatDashBoard m);


        [OperationContract]
        [WebInvoke(Method = "POST",
   ResponseFormat = WebMessageFormat.Json,
   RequestFormat = WebMessageFormat.Json,
   BodyStyle = WebMessageBodyStyle.Bare,
   UriTemplate = "json/RefundableDepositAddress1")]
        IList<string> JSONRefundableDepositAddress1(MyFlatDashBoard m);


        [OperationContract]
        [WebInvoke(Method = "POST",
   ResponseFormat = WebMessageFormat.Json,
   RequestFormat = WebMessageFormat.Json,
   BodyStyle = WebMessageBodyStyle.Bare,
   UriTemplate = "json/RefundableDepositAddress2")]
        IList<string> JSONRefundableDepositAddress2(MyFlatDashBoard m);


        [OperationContract]
        [WebInvoke(Method = "POST",
   ResponseFormat = WebMessageFormat.Json,
   RequestFormat = WebMessageFormat.Json,
   BodyStyle = WebMessageBodyStyle.Bare,
   UriTemplate = "json/RefundableDepositAddress3")]
        IList<string> JSONRefundableDepositAddress3(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
   ResponseFormat = WebMessageFormat.Json,
   RequestFormat = WebMessageFormat.Json,
   BodyStyle = WebMessageBodyStyle.Bare,
   UriTemplate = "json/RefundableDepositReceiptDetails1")]
        IList<string> JSONRefundableDepositReceiptDetails1(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
   ResponseFormat = WebMessageFormat.Json,
   RequestFormat = WebMessageFormat.Json,
   BodyStyle = WebMessageBodyStyle.Bare,
   UriTemplate = "json/RefundableDepositReceiptDetails2")]
        IList<string> JSONRefundableDepositReceiptDetails2(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
   ResponseFormat = WebMessageFormat.Json,
   RequestFormat = WebMessageFormat.Json,
   BodyStyle = WebMessageBodyStyle.Bare,
   UriTemplate = "json/RefundableDepositReceiptDetails3")]
        IList<string> JSONRefundableDepositReceiptDetails3(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
   ResponseFormat = WebMessageFormat.Json,
   RequestFormat = WebMessageFormat.Json,
   BodyStyle = WebMessageBodyStyle.Bare,
   UriTemplate = "json/RefundableDepositReceiptDetails4")]
        IList<string> JSONRefundableDepositReceiptDetails4(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
  ResponseFormat = WebMessageFormat.Json,
  RequestFormat = WebMessageFormat.Json,
  BodyStyle = WebMessageBodyStyle.Bare,
  UriTemplate = "json/ManualInvoiceAddressDetailsDues1")]
        IList<string> JSONManualInvoiceAddressDetailsDues1(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
  ResponseFormat = WebMessageFormat.Json,
  RequestFormat = WebMessageFormat.Json,
  BodyStyle = WebMessageBodyStyle.Bare,
  UriTemplate = "json/ManualInvoiceAddressDetailsDues2")]
        IList<string> JSONManualInvoiceAddressDetailsDues2(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
  ResponseFormat = WebMessageFormat.Json,
  RequestFormat = WebMessageFormat.Json,
  BodyStyle = WebMessageBodyStyle.Bare,
  UriTemplate = "json/ManualInvoiceBillsDetailsDues1")]
        IList<string> JSONManualInvoiceBillsDetailsDues1(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
  ResponseFormat = WebMessageFormat.Json,
  RequestFormat = WebMessageFormat.Json,
  BodyStyle = WebMessageBodyStyle.Bare,
  UriTemplate = "json/ManualInvoiceBillsDetailsDues2")]
        IList<string> JSONManualInvoiceBillsDetailsDues2(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
  ResponseFormat = WebMessageFormat.Json,
  RequestFormat = WebMessageFormat.Json,
  BodyStyle = WebMessageBodyStyle.Bare,
  UriTemplate = "json/ManualInvoiceReceiptAddressDetailsAdvance1")]
        IList<string> JSONManualInvoiceReceiptAddressDetailsAdvance1(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
 ResponseFormat = WebMessageFormat.Json,
 RequestFormat = WebMessageFormat.Json,
 BodyStyle = WebMessageBodyStyle.Bare,
 UriTemplate = "json/ManualInvoiceReceiptAddressDetailsAdvance2")] 
        IList<string> JSONManualInvoiceReceiptAddressDetailsAdvance2(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
 ResponseFormat = WebMessageFormat.Json,
 RequestFormat = WebMessageFormat.Json,
 BodyStyle = WebMessageBodyStyle.Bare,
 UriTemplate = "json/ManualInvoiceReceiptBillDetailsAdvance1")]
        IList<string> JSONManualInvoiceReceiptBillDetailsAdvance1(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
ResponseFormat = WebMessageFormat.Json,
RequestFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Bare,
UriTemplate = "json/ManualInvoiceReceiptBillDetailsAdvance2")]
        IList<string> JSONManualInvoiceReceiptBillDetailsAdvance2(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
ResponseFormat = WebMessageFormat.Json,
RequestFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Bare,
UriTemplate = "json/ManualInvoiceReceiptBillDetailsAdvance3")]
        IList<string> JSONManualInvoiceReceiptBillDetailsAdvance3(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
ResponseFormat = WebMessageFormat.Json,
RequestFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Bare,
UriTemplate = "json/ManualInvoiceReceiptBillDetailsAdvance4")]
        IList<string> JSONManualInvoiceReceiptBillDetailsAdvance4(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
ResponseFormat = WebMessageFormat.Json,
RequestFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Bare,
UriTemplate = "json/ManualInvoiceReceiptBillDetailsAdvance5")]
        IList<string> JSONManualInvoiceReceiptBillDetailsAdvance5(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
ResponseFormat = WebMessageFormat.Json,
RequestFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Bare,
UriTemplate = "json/ManualInvoiceReceiptManualDetailsAdvance1")]
        IList<string> JSONManualInvoiceReceiptManualDetailsAdvance1(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
ResponseFormat = WebMessageFormat.Json,
RequestFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Bare,
UriTemplate = "json/ManualInvoiceReceiptManualDetailsAdvance2")]
        IList<string> JSONManualInvoiceReceiptManualDetailsAdvance2(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
ResponseFormat = WebMessageFormat.Json,
RequestFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Bare,
UriTemplate = "json/ManualInvoiceReceiptAutoDetailsAdvance1")]
        IList<string> JSONManualInvoiceReceiptAutoDetailsAdvance1(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
ResponseFormat = WebMessageFormat.Json,
RequestFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Bare,
UriTemplate = "json/ManualInvoiceReceiptAutoDetailsAdvance2")] 
        IList<string> JSONManualInvoiceReceiptAutoDetailsAdvance2(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
ResponseFormat = WebMessageFormat.Json,
RequestFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Bare,
UriTemplate = "json/ManualInvoiceReceiptAutoTaxDetailsAdvance1")]
        IList<string> JSONManualInvoiceReceiptAutoTaxDetailsAdvance1(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
ResponseFormat = WebMessageFormat.Json,
RequestFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Bare,
UriTemplate = "json/ManualInvoiceReceiptAutoTaxDetailsAdvance2")]
        IList<string> JSONManualInvoiceReceiptAutoTaxDetailsAdvance2(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
ResponseFormat = WebMessageFormat.Json,
RequestFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Bare,
UriTemplate = "json/ManualInvoiceReceiptTaxDetailsAdvance")]
        IList<string> JSONManualInvoiceReceiptTaxDetailsAdvance(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
ResponseFormat = WebMessageFormat.Json,
RequestFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Bare,
UriTemplate = "json/ManualInvoiceReceiptManualTaxDetailsAdvance1")]
        IList<string> JSONManualInvoiceReceiptManualTaxDetailsAdvance1(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
ResponseFormat = WebMessageFormat.Json,
RequestFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Bare,
UriTemplate = "json/BindPendingBillGrid")]
        IList<string> JSONBindPendingBillGrid(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
ResponseFormat = WebMessageFormat.Json,
RequestFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Bare,
UriTemplate = "json/BindBankAndCashAccount")]
        IList<string> JSONBindBankAndCashAccount(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
ResponseFormat = WebMessageFormat.Json,
RequestFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Bare,
UriTemplate = "json/BindAdvancePaidDetails")]
        IList<string> JSONBindAdvancePaidDetails(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
ResponseFormat = WebMessageFormat.Json,
RequestFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Bare,
UriTemplate = "json/AlreadyPaidServices")]
        IList<string> JSONAlreadyPaidServices(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
ResponseFormat = WebMessageFormat.Json,
RequestFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Bare,
UriTemplate = "json/InserSweetHomeMemberReceiptDetail")]
        IList<string> JSONInserSweetHomeMemberReceiptDetail(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
ResponseFormat = WebMessageFormat.Json,
RequestFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Bare,
UriTemplate = "json/SaveMemberreceiptAndAllocation")]
        IList<string> JSONSaveMemberreceiptAndAllocation(MyFlatDashBoard m);


        [OperationContract]
        [WebInvoke(Method = "POST",
ResponseFormat = WebMessageFormat.Json,
RequestFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Bare,
UriTemplate = "json/UpdateMemberReceiptHeader")]
        IList<string> JSONUpdateMemberReceiptHeader(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
ResponseFormat = WebMessageFormat.Json,
RequestFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Bare,
UriTemplate = "json/UpdateManualInvoiceHeader")]
        IList<string> JSONUpdateManualInvoiceHeader(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
ResponseFormat = WebMessageFormat.Json,
RequestFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Bare,
UriTemplate = "json/BindFlatDetails")]
        IList<string> JSONBindFlatDetails(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
ResponseFormat = WebMessageFormat.Json,
RequestFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Bare,
UriTemplate = "json/UpComingAmenity")]
        IList<string> JSONUpComingAmenity(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
ResponseFormat = WebMessageFormat.Json,
RequestFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Bare,
UriTemplate = "json/PastAmenity")]
        IList<string> JSONPastAmenity(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
ResponseFormat = WebMessageFormat.Json,
RequestFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Bare,
UriTemplate = "json/CheckAvailability")]
        IList<string> JSONCheckAvailability(MyFlatDashBoard m);

//        [OperationContract]
//        [WebInvoke(Method = "POST",
//ResponseFormat = WebMessageFormat.Json,
//RequestFormat = WebMessageFormat.Json,
//BodyStyle = WebMessageBodyStyle.Bare,
//UriTemplate = "json/GetdataFacility")]
//        IList<string> JSONGetdataFacility(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
ResponseFormat = WebMessageFormat.Json,
RequestFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Bare,
UriTemplate = "json/BookPending")]
        IList<string> JSONBookPending(MyFlatDashBoard m);


        [OperationContract]
        [WebInvoke(Method = "POST",
ResponseFormat = WebMessageFormat.Json,
RequestFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Bare,
UriTemplate = "json/GetAllFacilities")]
        IList<string> JSONGetAllFacilities(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/ShowEditNotice")]
        IList<string> JSONShowEditNotice(notice m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/NoticeAWatingApproval")]
        IList<string> JSONNoticeAWatingApproval(Notice m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/PublishedAdminReport")]
        IList<string> JSONPublishedAdminReport(Notice m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/UpdateEditNotice")]
        IList<string> JSONUpdateEditNotice(Notice m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/PrintMemberManualInvoice1")]
        PrintMemberManualInvoice1 JSONPrintMemberManualInvoice1(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/PrintMemberManualInvoice2")]
        IList<string> JSONPrintMemberManualInvoice2(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/PrintMemberManualInvoice3")]
        IList<string> JSONPrintMemberManualInvoice3(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/PrintMemberInvoiceReceipt1")]
        PrintMemberInvoiceReceipt JSONPrintMemberInvoiceReceipt1(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/PrintMemberInvoiceReceipt2")]
        IList<string> JSONPrintMemberInvoiceReceipt2(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/PrintMemberInvoiceReceipt3")]
        IList<string> JSONPrintMemberInvoiceReceipt3(MyFlatDashBoard m); 

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/PrintMemberRefundableDeposit1")]
        PrintMemberRefundableDeposit JSONPrintMemberRefundableDeposit1(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/PrintMemberRefundableDeposit2")]
        IList<string> JSONPrintMemberRefundableDeposit2(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/PrintVendorexpenseinvoice1")]
        PVEI JSONPrintVendorexpenseinvoice1(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/PrintVendorexpenseinvoice2")]
        IList<string> JSONPrintVendorexpenseinvoice2(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/PrintVendorexpenseinvoice3")]
        IList<string> JSONPrintVendorexpenseinvoice3(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/PrintVendorInvoicePayment1")]
        PVIP JSONPrintVendorInvoicePayment1(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/PrintVendorInvoicePayment2")]
        IList<string> JSONPrintVendorInvoicePayment2(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/PrintVendorInvoicePayment3")]
        IList<string> JSONPrintVendorInvoicePayment3(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/PrintVendorInvoicePayment4")]
        IList<string> JSONPrintVendorInvoicePayment4(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/PrintNonMemberInvoiceReceipt1")]
        PNMIR JSONPrintNonMemberInvoiceReceipt1(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/PrintNonMemberInvoiceReceipt2")]
        IList<string> JSONPrintNonMemberInvoiceReceipt2(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/PrintNonMemberInvoiceReceipt3")]
        IList<string> JSONPrintNonMemberInvoiceReceipt3(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/PrintNonMemberInvoice1")]
        PNMI JSONPrintNonMemberInvoice1(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/PrintNonMemberInvoice2")]
        IList<string> JSONPrintNonMemberInvoice2(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/PrintNonMemberInvoice3")]
        IList<string> JSONPrintNonMemberInvoice3(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/AttendanceInfo")]
        IList<string> JSONAttendanceInfo(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/Open360History")]
        IList<string> JSONOpen360History(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/CloseOpenHistory")]
        IList<string> JSONCloseOpenHistory(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/DeleteAlbumRocord")]
        IList<string> JSONDeleteAlbumRocord(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/BookingServiceHistory")]
        IList<string> JSONBookingServiceHistory(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/BookingServiceHistory2")]
        IList<string> JSONBookingServiceHistory2(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/ShowCommentView")]
        IList<string> JSONShowCommentView(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "json/EditAlbumRocord")]
        IList<string> JSONEditAlbumRocord(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
      ResponseFormat = WebMessageFormat.Json,
      RequestFormat = WebMessageFormat.Json,
      BodyStyle = WebMessageBodyStyle.Bare,
      UriTemplate = "json/GetFamilyMemberForFlat")]
        IList<string> JSONGetFamilyMemberForFlat(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
      ResponseFormat = WebMessageFormat.Json,
      RequestFormat = WebMessageFormat.Json,
      BodyStyle = WebMessageBodyStyle.Bare,
      UriTemplate = "json/DeleteFamilyMemberForFlat")]
        IList<string> JSONDeleteFamilyMemberForFlat(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
     ResponseFormat = WebMessageFormat.Json,
     RequestFormat = WebMessageFormat.Json,
     BodyStyle = WebMessageBodyStyle.Bare,
     UriTemplate = "json/UpdateFamilyMemberForFlat")]
        IList<string> JSONUpdateFamilyMemberForFlat(MyFlat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
      ResponseFormat = WebMessageFormat.Json,
      RequestFormat = WebMessageFormat.Json,
      BodyStyle = WebMessageBodyStyle.Bare,
      UriTemplate = "json/GetDirectMessageDetails")]
        IList<string> JSONGetDirectMessageDetails(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
      ResponseFormat = WebMessageFormat.Json,
      RequestFormat = WebMessageFormat.Json,
      BodyStyle = WebMessageBodyStyle.Bare,
      UriTemplate = "json/GetUserNotification")]
        IList<string> JSONGetUserNotification(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
      ResponseFormat = WebMessageFormat.Json,
      RequestFormat = WebMessageFormat.Json,
      BodyStyle = WebMessageBodyStyle.Bare,
      UriTemplate = "json/DeleteNotification")]
        IList<string> JSONDeleteNotification(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
      ResponseFormat = WebMessageFormat.Json,
      RequestFormat = WebMessageFormat.Json,
      BodyStyle = WebMessageBodyStyle.Bare,
      UriTemplate = "json/Getdefaulterslist")]
        IList<string> JSONGetdefaulterslist(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
      ResponseFormat = WebMessageFormat.Json,
      RequestFormat = WebMessageFormat.Json, 
      BodyStyle = WebMessageBodyStyle.Bare,
      UriTemplate = "json/BindUsersBlocks")]
        IList<string> JSONBindUsersBlocks(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
      ResponseFormat = WebMessageFormat.Json,
      RequestFormat = WebMessageFormat.Json,
      BodyStyle = WebMessageBodyStyle.Bare,
      UriTemplate = "json/SendSMSToDefaulterUser")]
        IList<string> JSONSendSMSToDefaulterUser(EmailSMS m);

        [OperationContract]
        [WebInvoke(Method = "POST",
      ResponseFormat = WebMessageFormat.Json,
      RequestFormat = WebMessageFormat.Json,
      BodyStyle = WebMessageBodyStyle.Bare,
      UriTemplate = "json/SendEmailToDefaulterUser")]
        IList<string> JSONSendEmailToDefaulterUser(EmailSMS m);

        [OperationContract]
        [WebInvoke(Method = "POST",
      ResponseFormat = WebMessageFormat.Json,
      RequestFormat = WebMessageFormat.Json,
      BodyStyle = WebMessageBodyStyle.Bare,
      UriTemplate = "json/PrintPurchaseRequestGrid")]
        IList<string> JSONPrintPurchaseRequestGrid(PurchaseRequest m);

        [OperationContract]
        [WebInvoke(Method = "POST",
      ResponseFormat = WebMessageFormat.Json,
      RequestFormat = WebMessageFormat.Json,
      BodyStyle = WebMessageBodyStyle.Bare,
      UriTemplate = "json/BindPurchaseRequestGrid")]
        IList<string> JSONBindPurchaseRequestGrid(PurchaseRequest m);

        [OperationContract]
        [WebInvoke(Method = "POST",
     ResponseFormat = WebMessageFormat.Json,
     RequestFormat = WebMessageFormat.Json,
     BodyStyle = WebMessageBodyStyle.Bare,
     UriTemplate = "json/PurchaseRequestApproved")]
        IList<string> JSONPurchaseRequestApproved(PurchaseRequest m);

        [OperationContract]
        [WebInvoke(Method = "POST",
     ResponseFormat = WebMessageFormat.Json,
     RequestFormat = WebMessageFormat.Json,
     BodyStyle = WebMessageBodyStyle.Bare,
     UriTemplate = "json/PurchaseRequestUnApproved")]
        IList<string> JSONPurchaseRequestUnApproved(PurchaseRequest m);

        [OperationContract]
        [WebInvoke(Method = "POST",
    ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare,
    UriTemplate = "json/PurchaseRequestApprovedByMe")]
        IList<string> JSONPurchaseRequestApprovedByMe(PurchaseRequest m);

        [OperationContract]
        [WebInvoke(Method = "POST",
    ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare,
    UriTemplate = "json/PurchaseRequestUnApprovedByMe")]
        IList<string> JSONPurchaseRequestUnApprovedByMe(PurchaseRequest m);

        [OperationContract]
        [WebInvoke(Method = "POST",
    ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare,
    UriTemplate = "json/RejectPurchaseRequest")]
        IList<string> JSONRejectPurchaseRequest(PurchaseRequest m);

        [OperationContract]
        [WebInvoke(Method = "POST",
    ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare,
    UriTemplate = "json/BindMemberDetailsForApprovals")]
        IList<string> JSONBindMemberDetailsForApprovals(PurchaseRequest m);

        [OperationContract]
        [WebInvoke(Method = "POST",
    ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare,
    UriTemplate = "json/BindTermsServices")]
        IList<string> JSONBindTermsServices(PurchaseRequest m);

        [OperationContract]
        [WebInvoke(Method = "POST",
    ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare,
    UriTemplate = "json/BindVendorDetails")]
        IList<string> JSONBindVendorDetails(PurchaseRequest m);

        [OperationContract]
        [WebInvoke(Method = "POST",
    ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare,
    UriTemplate = "json/BindAccountDetailsServices")]
        IList<string> JSONBindAccountDetailsServices(PurchaseRequest m);

        [OperationContract]
        [WebInvoke(Method = "POST",
    ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare,
    UriTemplate = "json/CurrentActivitiesBuyTiketServices")]
        IList<string> JSONCurrentActivitiesBuyTiketServices(MyFlat m);

        [OperationContract]
        [WebInvoke(Method = "POST",
      ResponseFormat = WebMessageFormat.Json,
      RequestFormat = WebMessageFormat.Json,
      BodyStyle = WebMessageBodyStyle.Bare,
      UriTemplate = "json/DeleteFeedbackRocord")]
        IList<string> JSONDeleteFeedbackRocord(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
      ResponseFormat = WebMessageFormat.Json,
      RequestFormat = WebMessageFormat.Json,
      BodyStyle = WebMessageBodyStyle.Bare,
      UriTemplate = "json/DeleteAlbumPhotosServices")] 
        IList<string> JSONDeleteAlbumPhotosServices(Pixar m);

        [OperationContract]
        [WebInvoke(Method = "POST",
      ResponseFormat = WebMessageFormat.Json,
      RequestFormat = WebMessageFormat.Json,
      BodyStyle = WebMessageBodyStyle.Bare,
      UriTemplate = "json/InsertFeedbackOfStaffService")]
        IList<string> JSONInsertFeedbackOfStaffService(FeedBack m);

        [OperationContract]
        [WebInvoke(Method = "POST",
      ResponseFormat = WebMessageFormat.Json,
      RequestFormat = WebMessageFormat.Json,
      BodyStyle = WebMessageBodyStyle.Bare,
      UriTemplate = "json/SerchSubServiceByTxt")]
        IList<string> JSONSerchSubServiceByTxt(MyAds m);

        [OperationContract]
        [WebInvoke(Method = "POST",
    ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare, 
    UriTemplate = "json/SaveApproveServices")]
        IList<string> JSONSaveApproveServices(PurchaseRequest m);

        [OperationContract]
        [WebInvoke(Method = "POST",
     ResponseFormat = WebMessageFormat.Json,
     RequestFormat = WebMessageFormat.Json,
     BodyStyle = WebMessageBodyStyle.Bare,
     UriTemplate = "json/PrintMemberAutoInvoiceAfterPost")]
        PrintMemberAutoInvoiceAfterPost JSONPrintMemberAutoInvoiceAfterPost(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
     ResponseFormat = WebMessageFormat.Json,
     RequestFormat = WebMessageFormat.Json,
     BodyStyle = WebMessageBodyStyle.Bare,
     UriTemplate = "json/PrintMemberAutoInvoiceBeforePost")]
        PMAIBPN JSONPrintMemberAutoInvoiceBeforePost(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
     ResponseFormat = WebMessageFormat.Json,
     RequestFormat = WebMessageFormat.Json,
     BodyStyle = WebMessageBodyStyle.Bare,
     UriTemplate = "json/SuperAdminHelpDeskCategoryBind")]
        IList<string> JSONSuperAdminHelpDeskCategoryBind(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
     ResponseFormat = WebMessageFormat.Json,
     RequestFormat = WebMessageFormat.Json,
     BodyStyle = WebMessageBodyStyle.Bare,
     UriTemplate = "json/BindRiseTicketSuperAdmin")]
        IList<string> JSONBindRiseTicketSuperAdmin(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
     ResponseFormat = WebMessageFormat.Json,
     RequestFormat = WebMessageFormat.Json,
     BodyStyle = WebMessageBodyStyle.Bare,
     UriTemplate = "json/TicketRiseServices")]
        IList<string> JSONTicketRiseServices(TICKETRISE T);

        [OperationContract]
        [WebInvoke(Method = "POST",
     ResponseFormat = WebMessageFormat.Json,
     RequestFormat = WebMessageFormat.Json,
     BodyStyle = WebMessageBodyStyle.Bare,
     UriTemplate = "json/BindSubCategoryWithCategoryIdSA")]
        IList<string> JSONBindSubCategoryWithCategoryIdSA(TICKETRISE T);

        [OperationContract]
        [WebInvoke(Method = "POST",
     ResponseFormat = WebMessageFormat.Json,
     RequestFormat = WebMessageFormat.Json,
     BodyStyle = WebMessageBodyStyle.Bare,
     UriTemplate = "json/GetDetailsOFTicketToSuperAdmin")]
        IList<string> JSONGetDetailsOFTicketToSuperAdmin(TICKETRISE T);

        [OperationContract]
        [WebInvoke(Method = "POST",
     ResponseFormat = WebMessageFormat.Json,
     RequestFormat = WebMessageFormat.Json,
     BodyStyle = WebMessageBodyStyle.Bare,
     UriTemplate = "json/ShowCommentOfTicketSuperAdmin")]
        IList<string> JSONShowCommentOfTicketSuperAdmin(TICKETRISE T);

        [OperationContract]
        [WebInvoke(Method = "POST",
     ResponseFormat = WebMessageFormat.Json,
     RequestFormat = WebMessageFormat.Json,
     BodyStyle = WebMessageBodyStyle.Bare,
     UriTemplate = "json/CommnetAndUpdateTicketSuperAdminUSer")]
        IList<string> JSONCommnetAndUpdateTicketSuperAdminUSer(TICKETRISE T);

        [OperationContract]
        [WebInvoke(Method = "POST",
    ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare,
    UriTemplate = "json/OnlinePayment")]
        OnlinePaymentDeatils_Main JSONOnlinePayment(OnlinePayment O);

        [OperationContract]
        [WebInvoke(Method = "POST",
    ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare,
    UriTemplate = "json/AdvancesPayment")]
        OnlinePaymentDeatils_Main JSONAdvancesPayment(OnlinePayment O); 

        [OperationContract]
        [WebInvoke(Method = "POST",
    ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare,
    UriTemplate = "json/OnlinePaymentAfterCompleted")]
        IList<string> JSONOnlinePaymentAfterCompleted(OPAC O);

        [OperationContract]
        [WebInvoke(Method = "POST",
    ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare,
    UriTemplate = "json/CreatePurchaseRequestServices")]
        IList<string> JSONCreatePurchaseRequestServices(PurchaseRequest m);

        [OperationContract]
        [WebInvoke(Method = "POST",
    ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare,
    UriTemplate = "json/BindPurchaseRequestDetails")]
        FinalBPRD JSONBindPurchaseRequestDetails(PurchaseRequest m);

        [OperationContract]
        [WebInvoke(Method = "POST",
    ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare,
    UriTemplate = "json/BindDetailsForPurchaseRequestEdit")]
        FinalBDFPRE JSONBindDetailsForPurchaseRequestEdit(PurchaseRequest m);

        [OperationContract]
        [WebInvoke(Method = "POST",
    ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare,
    UriTemplate = "json/DeletePurchaseRequest")]
        IList<string> JSONDeletePurchaseRequest(PurchaseRequest m);

        [OperationContract]
        [WebInvoke(Method = "POST",
    ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare,
    UriTemplate = "json/RevereseMemberAndNonmemberTransactions")]
        IList<string> JSONRevereseMemberAndNonmemberTransactions(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
    ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare,
    UriTemplate = "json/GetMeetingDedatilsForEdit")]
        GetMeetingDedatils JSONGetMeetingDedatilsForEdit(ProjectsMeeting P);

        [OperationContract]
        [WebInvoke(Method = "POST",
    ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare,
    UriTemplate = "json/GetFileForEditMeeting")]
        IList<string> JSONGetFileForEditMeeting(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
    ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare,
    UriTemplate = "json/DeleteFileForMeeting")]
        IList<string> JSONDeleteFileForMeeting(MyFlatDashBoard m);

        [OperationContract]
        [WebInvoke(Method = "POST",
    ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare,
    UriTemplate = "json/BindUserDetailsForSwitchSociety")]
        IList<string> JSONBindUserDetailsForSwitchSociety(LoginModel m);

        [OperationContract]
        [WebInvoke(Method = "POST",
    ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare,
    UriTemplate = "json/LoginSwitchSociety")]
        IList<string> JSONLoginSwitchSociety(LoginModel m);
         

    } 
}
