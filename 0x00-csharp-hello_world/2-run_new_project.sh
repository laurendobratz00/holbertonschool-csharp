#!/usr/bin/env bash
# This script initializes and builds a new C# project inside a folder titled 1-new_project
dotnet new console -o 2-new_project
dotnet build 2-new_project
dotnet run --project 2-new_project
