//This is a source code or part of Openmiracle project
//Copyright (C) 2013  Openmiracle
//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.
//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.
//You should have received a copy of the GNU General Public License
//along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;    
using System.Collections.Generic;    
using System.Text;    
//<summary>    
//Summary description for DailyAttendanceDetailsInfo    
//</summary>    
namespace Open_Miracle    
{    
class DailyAttendanceDetailsInfo    
{    
    private decimal _dailyAttendanceDetailsId;    
    private decimal _dailyAttendanceMasterId;    
    private decimal _employeeId;    
    private string _status;    
    private string _narration;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal DailyAttendanceDetailsId    
    {    
        get { return _dailyAttendanceDetailsId; }    
        set { _dailyAttendanceDetailsId = value; }    
    }    
    public decimal DailyAttendanceMasterId    
    {    
        get { return _dailyAttendanceMasterId; }    
        set { _dailyAttendanceMasterId = value; }    
    }    
    public decimal EmployeeId    
    {    
        get { return _employeeId; }    
        set { _employeeId = value; }    
    }    
    public string Status    
    {    
        get { return _status; }    
        set { _status = value; }    
    }    
    public string Narration    
    {    
        get { return _narration; }    
        set { _narration = value; }    
    }    
    public DateTime ExtraDate    
    {    
        get { return _extraDate; }    
        set { _extraDate = value; }    
    }    
    public string Extra1    
    {    
        get { return _extra1; }    
        set { _extra1 = value; }    
    }    
    public string Extra2    
    {    
        get { return _extra2; }    
        set { _extra2 = value; }    
    }    
    
}    
}