﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Common.Application.Validation.CustomValidation.IFormFile;

public class MaxFileSizeAttribute : ValidationAttribute, IClientModelValidator
{
    private readonly int file_size;
    public MaxFileSizeAttribute(int fileSize)
    {
        file_size = fileSize * 1024;
    }

    public override bool IsValid(object? value)
    {
        var fileInput = value as Microsoft.AspNetCore.Http.IFormFile;
        if (fileInput == null) return true;

        var size = fileInput.Length / 1024;
        return size <= file_size;
    }

    public void AddValidation(ClientModelValidationContext context)
    {
        if (!context.Attributes.ContainsKey("data-val"))
            context.Attributes.Add("data-val", "true");
        context.Attributes.Add("fileSize", file_size.ToString());
        context.Attributes.Add("data-val-fileSize", ErrorMessage);
    }
}