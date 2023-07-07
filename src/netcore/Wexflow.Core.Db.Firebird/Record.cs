﻿namespace Wexflow.Core.Db.Firebird
{
    public class Record : Core.Db.Record
    {
        public const string ColumnNameId = "ID";
        public const string ColumnNameName = "NAME";
        public const string ColumnNameDescription = "DESCRIPTION";
        public const string ColumnNameApproved = "APPROVED";
        public const string ColumnNameStartDate = "START_DATE";
        public const string ColumnNameEndDate = "END_DATE";
        public const string ColumnNameComments = "COMMENTS";
        public const string ColumnNameManagerComments = "MANAGER_COMMENTS";
        public const string ColumnNameCreatedBy = "CREATED_BY";
        public const string ColumnNameCreatedOn = "CREATED_ON";
        public const string ColumnNameModifiedBy = "MODIFIED_BY";
        public const string ColumnNameModifiedOn = "MODIFIED_ON";
        public const string ColumnNameAssignedTo = "ASSIGNED_TO";
        public const string ColumnNameAssignedOn = "ASSIGNED_ON";

        public const string TableStruct = "(" + ColumnNameId + " integer generated by default as identity primary key, "
                                                        + ColumnNameName + " VARCHAR(512), "
                                                        + ColumnNameDescription + " BLOB SUB_TYPE TEXT, "
                                                        + ColumnNameApproved + " BOOLEAN, "
                                                        + ColumnNameStartDate + " TIMESTAMP, "
                                                        + ColumnNameEndDate + " TIMESTAMP, "
                                                        + ColumnNameComments + " BLOB SUB_TYPE TEXT, "
                                                        + ColumnNameManagerComments + " BLOB SUB_TYPE TEXT, "
                                                        + ColumnNameCreatedBy + " INTEGER, "
                                                        + ColumnNameCreatedOn + " TIMESTAMP, "
                                                        + ColumnNameModifiedBy + " INTEGER, "
                                                        + ColumnNameModifiedOn + " TIMESTAMP, "
                                                        + ColumnNameAssignedTo + " INTEGER, "
                                                        + ColumnNameAssignedOn + " TIMESTAMP)";

        public int Id { get; set; }

        public override string GetDbId()
        {
            return Id.ToString();
        }
    }
}
