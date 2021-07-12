#!/usr/bin/env bash
# Ininitializes a new project and builds it and runs it.
dotnet new console -o 2-new_project 
dotnet build 2-new_project
dotnet run --project 2-new_project