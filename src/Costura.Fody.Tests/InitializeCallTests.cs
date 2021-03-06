﻿using Fody;

public class InitializeCallTests : BasicTests
{
    private static readonly TestResult testResult;

    static InitializeCallTests()
    {
        testResult = WeavingHelper.CreateIsolatedAssemblyCopy("AssemblyToProcess.dll",
            "<Costura />",
            new[] { "AssemblyToReference.dll", "AssemblyToReferencePreEmbedded.dll", "ExeToReference.exe" },
            "InitializeCall");
    }

    public override TestResult TestResult => testResult;
}
