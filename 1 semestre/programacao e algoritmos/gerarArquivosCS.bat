for /l %%i in (1, 1, 26) do (
    setlocal enabledelayedexpansion

    set n=%%i
    if !n! lss 10 (
        set n=0!n!
    )
    type nul > "lista 4"/e!n!.cs
    endlocal
)