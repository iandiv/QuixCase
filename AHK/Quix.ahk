
#SingleInstance, Force
SendMode Input
SetWorkingDir, %A_ScriptDir%





contextcolor()
;0=Default
;1=AllowDark
;2=ForceDark
;3=ForceLight
;4=Max
contextcolor(color:=1) 
{
    static uxtheme := DllCall("GetModuleHandle", "str", "uxtheme", "ptr")
    static SetPreferredAppMode := DllCall("GetProcAddress", "ptr", uxtheme, "ptr", 135, "ptr")
    static FlushMenuThemes := DllCall("GetProcAddress", "ptr", uxtheme, "ptr", 136, "ptr")
    DllCall(SetPreferredAppMode, "int", color)
    DllCall(FlushMenuThemes)
}

Menu, Tray, NoStandard
Menu, Tray, Add, Configure  , Config
Menu, Tray, Add
Menu, Tray, Add, Exit  , QuitScript
Menu, Tray, Tip , QuixCase

Menu, CaseMenu, Add, &Sentence case, CaseSentence
Menu, CaseMenu, Add, &UPPERCASE, CaseUpper
Menu, CaseMenu, Add, &lowercase, CaseLower
Menu, CaseMenu, Add
Menu, CaseMenu, Add, &Capitalize Each Word, CaseCEW 
Menu, CaseMenu, Add, &tOGGLE cASE, CaseReverse 

FileRead, ConfigContents, config.ini
; Split the contents into an array of lines
StringSplit, ConfigLines, ConfigContents, `n

Hotkey, %ConfigLines2%, ShowMenu
Return


ShowMenu:
GetText(temporaryText)
If NOT ERRORLEVEL
    Menu, CaseMenu, Show
Return

Config:
IfWinNotExist, ahk_exe QuixCase.exe
{
    Run, QuixCase.exe
}else{
     WinActivate
}

Return

ProcessExist(exe)
{
    Process, Exist, %exe%
    return ErrorLevel
}

CaseUpper:
StringUpper, temporaryText, temporaryText
SetText(temporaryText)
Return

CaseLower:
StringLower, temporaryText, temporaryText
SetText(temporaryText)
Return

CaseCEW:
StringLower, temporaryText, temporaryText, T
SetText(temporaryText)
Return

CaseSentence:
StringLower, temporaryText, temporaryText
temporaryText := RegExReplace(temporaryText, "((?:^|[.!?]\s+)[a-z])", "$u1")
SetText(temporaryText)
Return

CaseReverse:
    temporaryText := ReverseCase(temporaryText)
    SetText(temporaryText)
    Return
ReverseCase(text) {
    reversedText := ""
    Loop, Parse, text
    {
        char := A_LoopField
        if char is lower
            char := Chr(Asc(char) - 32) ; Convert lowercase to uppercase
        else if char is upper
            char :=  Chr(Asc(char) + 32)  ; Convert uppercase to lowercase
        reversedText .= char
    }
    return reversedText
}



; Handy function.
; Copies the selected text to a variable while preserving the clipboard.
GetText(ByRef txt = "") {
    SavedClip := ClipboardAll
    Clipboard =
    Send ^c
    ClipWait 0.5
    If ERRORLEVEL {
        Clipboard := SavedClip
        txt =
        Return
    }
    txt := Clipboard
    Clipboard := SavedClip
    Return txt
}

; Pastes text from a variable while preserving the clipboard.
SetText(txt) {
    SavedClip := ClipboardAll
    Clipboard =
    Sleep 20
    Clipboard := txt
    Send ^v
    Sleep 100
    Clipboard := SavedClip
    Return
}
; QuitScript subroutine
QuitScript:
If ProcessExist("QuixCase.exe")
{
    Process, Close, QuixCase.exe
}
 ExitApp
Return