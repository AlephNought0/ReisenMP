// SPDX-FileCopyrightText: 2026 AlephNought0
// SPDX-License-Identifier: GPL-3.0-or-later
//
// This file is subject to an additional permission under GNU GPL version 3
// section 7. See LICENSE-EXCEPTION in the project root for details.

namespace ReisenMP;

[BepInEx.BepInPlugin("io.github.alephnought0.reisenmp", "ReisenMP", "0.1.0")]
public class ReisenMPPlugin : BepInEx.BaseUnityPlugin
{
    private void Awake()
    {
        Logger.LogInfo("Current Garbage Collector is incremental: " + UnityEngine.Scripting.GarbageCollector.isIncremental);
    }
}
