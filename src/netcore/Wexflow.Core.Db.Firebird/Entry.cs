﻿namespace Wexflow.Core.Db.Firebird
{
    public class Entry : Core.Db.Entry
    {
        public const string ColumnNameId = "ID";
        public const string ColumnNameName = "NAME";
        public const string ColumnNameDescription = "DESCRIPTION";
        public const string ColumnNameLaunchType = "LAUNCH_TYPE";
        public const string ColumnNameStatusDate = "STATUS_DATE";
        public const string ColumnNameStatus = "STATUS";
        public const string ColumnNameWorkflowId = "WORKFLOW_ID";
        public const string ColumnNameJobId = "JOB_ID";
        public const string ColumnNameLogs = "LOGS";

        public const string TableStruct = "(" + ColumnNameId + " integer generated by default as identity primary key, " + ColumnNameName + " VARCHAR(255), " + ColumnNameDescription + " VARCHAR(255), " + ColumnNameLaunchType + " INTEGER, " + ColumnNameStatusDate + " TIMESTAMP, " + ColumnNameStatus + " INTEGER, " + ColumnNameWorkflowId + " INTEGER, " + ColumnNameJobId + " VARCHAR(255), " + ColumnNameLogs + " BLOB SUB_TYPE TEXT)";

        public int Id { get; set; }

        public override string GetDbId()
        {
            return Id.ToString();
        }
    }
}
