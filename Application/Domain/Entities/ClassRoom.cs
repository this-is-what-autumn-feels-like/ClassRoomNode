using Application.Domain.ValueObjects;

namespace Application.Domain.Entities;

public class ClassRoom : BaseEntity<ClassRoomId>
{
    public required OrganizationId OrganizationId { get; init; }

    public required OrgMemberId OrgMemberCreatorId { get; init; }

    #region RelationShips

    public Organization? Organization { get; init; }

    public OrgMember? OrgMember { get; init; }

    #endregion
}