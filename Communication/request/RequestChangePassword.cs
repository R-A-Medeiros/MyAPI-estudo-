﻿namespace MyFirstAPI.Communication.request;

public class RequestChangePassword
{
    public string CurrentPassword { get; set; } = string.Empty;
    public string NewPassword { get; set; } = string.Empty;
}