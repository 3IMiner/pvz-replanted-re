# System.Void UpdateShooter()

- 类：`Plant`
- 汇编行数：345

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,30h
	cmp byte ptr [184EEB63Fh],0
	mov rbx,rcx
	jne short 00000001806BC451h
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C87218h]
	call 00000001804FEB70h
	mov byte ptr [184EEB63Fh],1
	mov eax,[rbx+0A4h]
	dec eax
	mov [rsp+40h],rdi
	mov [rbx+0A4h],eax
	test eax,eax
	jg near ptr 00000001806BC69Ah
	mov rcx,[184C2AFC0h]
	mov edi,[rbx+0A8h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806BC487h
	call 00000001804FEEB0h
	xor edx,edx
	mov ecx,0Fh
	call 00000001806CBE80h
	sub edi,eax
	cmp dword ptr [rbx+70h],12h
	mov [rbx+0A4h],edi
	je near ptr 00000001806BC690h
	cmp dword ptr [rbx+70h],1Dh
	je near ptr 00000001806BC5ABh
	cmp dword ptr [rbx+70h],1Ch
	je short 00000001806BC500h
	cmp dword ptr [rbx+70h],1Ah
	je short 00000001806BC4D1h
	mov edx,[rbx+34h]
	xor r9d,r9d
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806AFB20h
	jmp near ptr 00000001806BC69Ah
	cmp dword ptr [rbx+88h],20h
	je short 00000001806BC4BBh
	cmp dword ptr [rbx+88h],1Eh
	jne near ptr 00000001806BC69Ah
	mov edx,[rbx+34h]
	xor r9d,r9d
	mov r8d,1
	mov rcx,rbx
	call 00000001806AFB20h
	jmp near ptr 00000001806BC69Ah
	mov edx,[rbx+34h]
	xor r9d,r9d
	mov r8d,1
	mov rcx,rbx
	call 00000001806AFB20h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BC70Ah
	movss xmm1,dword ptr [183C33DBCh]
	xor r9d,r9d
	xor r8d,r8d
	call 000000018060F880h
	mov rdi,[rbx+140h]
	mov rcx,rdi
	test rdi,rdi
	je near ptr 00000001806BC70Ah
	xor r8d,r8d
	xor edx,edx
	call 00000001807C78E0h
	xor r9d,r9d
	mov r8d,2
	movaps xmm1,xmm0
	mov rcx,rdi
	call 00000001807C8790h
	mov rdi,[rbx+140h]
	mov rcx,rdi
	test rdi,rdi
	je near ptr 00000001806BC70Ah
	xor r8d,r8d
	xor edx,edx
	call 00000001807C78A0h
	mov rdx,[184C87218h]
	movaps xmm3,xmm0
	mov r8d,2
	mov qword ptr [rsp+20h],0
	mov rcx,rdi
	call 00000001807C8210h
	jmp near ptr 00000001806BC69Ah
	cmp byte ptr [184EEB653h],0
	jne short 00000001806BC5C7h
	lea rcx,[184C983E8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB653h],1
	xor edx,edx
	mov rcx,rbx
	call 00000001806AF750h
	test al,al
	je near ptr 00000001806BC69Ah
	cmp byte ptr [184EEB658h],0
	mov rdi,[184C983E8h]
	jne short 00000001806BC608h
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	test rdi,rdi
	je near ptr 00000001806BC70Ah
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rdi
	call 0000000182A24E50h
	mov rcx,[rbx+140h]
	mov rdi,rax
	test rcx,rcx
	je near ptr 00000001806BC70Ah
	movss xmm1,dword ptr [183C33DBCh]
	xor r9d,r9d
	xor r8d,r8d
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BC70Ah
	movss xmm3,dword ptr [183C33FB8h]
	xor r8d,r8d
	mov qword ptr [rsp+28h],0
	mov rdx,rdi
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	mov dword ptr [rbx+0DCh],28h
	jmp short 00000001806BC69Ah
	xor edx,edx
	mov rcx,rbx
	call 00000001806B26F0h
	cmp dword ptr [rbx+0A4h],32h
	jne short 00000001806BC6BAh
	cmp dword ptr [rbx+70h],2Bh
	jne short 00000001806BC6BAh
	mov edx,[rbx+34h]
	xor r9d,r9d
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806AFB20h
	cmp dword ptr [rbx+0A4h],19h
	jne short 00000001806BC6FFh
	cmp dword ptr [rbx+70h],7
	je short 00000001806BC6EEh
	cmp dword ptr [rbx+70h],34h
	je short 00000001806BC6EEh
	cmp dword ptr [rbx+70h],1Ch
	jne short 00000001806BC6FFh
	mov edx,[rbx+34h]
	xor r9d,r9d
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806AFB20h
	mov r8d,1
	jmp short 00000001806BC6F1h
	xor r8d,r8d
	mov edx,[rbx+34h]
	xor r9d,r9d
	mov rcx,rbx
	call 00000001806AFB20h
	mov rdi,[rsp+40h]
	add rsp,30h
	pop rbx
	ret
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -48
	004 Compare [0x184EEB63F], 0
	005 Move rbx, rcx
	006 JumpIfNotEqual {12}
	007 LoadAddress rcx, [0x184C2AFC0]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 LoadAddress rcx, [0x184C87218]
	010 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	011 Move [0x184EEB63F], 1
	012 Move rax, [rbx+164]
	013 Subtract rax, rax, 1
	014 Move stack:0x40, rdi
	015 Move [rbx+164], rax
	016 Compare rax, 0
	017 JumpIfGreater {137}
	018 Move rcx, typeof(Reloaded.Gameplay.Common)
	019 Move rdi, [rbx+168]
	020 Compare [rcx+228], 0
	021 JumpIfNotEqual {23}
	022 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	023 Move rdx, 0
	024 Move rcx, 15
	025 Call Common.Rand, rcx, rdx
	026 Subtract rdi, rdi, rax
	027 Compare [rbx+112], 18
	028 Move [rbx+164], rdi
	029 JumpIfEqual {134}
	030 Compare [rbx+112], 29
	031 JumpIfEqual {90}
	032 Compare [rbx+112], 28
	033 JumpIfEqual {52}
	034 Compare [rbx+112], 26
	035 JumpIfEqual {42}
	036 Move rdx, [rbx+52]
	037 Move r9, 0
	038 Move r8, 0
	039 Move rcx, rbx
	040 Call Plant.FindTargetAndFire, rcx, rdx, r8
	041 Goto {137}
	042 Compare [rbx+136], 32
	043 JumpIfEqual {36}
	044 Compare [rbx+136], 30
	045 JumpIfNotEqual {137}
	046 Move rdx, [rbx+52]
	047 Move r9, 0
	048 Move r8, 1
	049 Move rcx, rbx
	050 Call Plant.FindTargetAndFire, rcx, rdx, r8
	051 Goto {137}
	052 Move rdx, [rbx+52]
	053 Move r9, 0
	054 Move r8, 1
	055 Move rcx, rbx
	056 Call Plant.FindTargetAndFire, rcx, rdx, r8
	057 Move rcx, [rbx+320]
	058 Compare rcx, 0
	059 JumpIfEqual {171}
	060 Move xmm1, [0x183C33DBC]
	061 Move r9, 0
	062 Move r8, 0
	063 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	064 Move rdi, [rbx+320]
	065 Move rcx, rdi
	066 Compare rdi, 0
	067 JumpIfEqual {171}
	068 Move r8, 0
	069 Move rdx, 0
	070 Call ReloadedCharacterController.GetAnimationTimeOnTrack, rcx, rdx
	071 Move r9, 0
	072 Move r8, 2
	073 Move xmm1, xmm0
	074 Move rcx, rdi
	075 Call ReloadedCharacterController.SetAnimationTimeOnTrack, rcx, rdx, r8
	076 Move rdi, [rbx+320]
	077 Move rcx, rdi
	078 Compare rdi, 0
	079 JumpIfEqual {171}
	080 Move r8, 0
	081 Move rdx, 0
	082 Call ReloadedCharacterController.GetAnimationRateOnTrack, rcx, rdx
	083 Move rdx, "head_idle"
	084 Move xmm3, xmm0
	085 Move r8, 2
	086 Move stack:0x20, 0
	087 Move rcx, rdi
	088 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9
	089 Goto {137}
	090 Compare [0x184EEB653], 0
	091 JumpIfNotEqual {95}
	092 LoadAddress rcx, [0x184C983E8]
	093 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	094 Move [0x184EEB653], 1
	095 Move rdx, 0
	096 Move rcx, rbx
	097 Call Plant.FindStarFruitTarget, rcx, rdx
	098 Compare rax, 0
	099 JumpIfEqual {137}
	100 Compare [0x184EEB658], 0
	101 Move rdi, "anim_shoot"
	102 JumpIfNotEqual {108}
	103 LoadAddress rcx, [0x184C92A80]
	104 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	105 LoadAddress rcx, [0x184C911F8]
	106 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	107 Move [0x184EEB658], 1
	108 Compare rdi, 0
	109 JumpIfEqual {171}
	110 Move r8, ""
	111 Move r9, 0
	112 Move rdx, "anim_"
	113 Move rcx, rdi
	114 Call String.Replace, rcx, rdx, r8
	115 Move rcx, [rbx+320]
	116 Move rdi, rax
	117 Compare rcx, 0
	118 JumpIfEqual {171}
	119 Move xmm1, [0x183C33DBC]
	120 Move r9, 0
	121 Move r8, 0
	122 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	123 Move rcx, [rbx+320]
	124 Compare rcx, 0
	125 JumpIfEqual {171}
	126 Move xmm3, [0x183C33FB8]
	127 Move r8, 0
	128 Move stack:0x28, 0
	129 Move rdx, rdi
	130 Move stack:0x20, 3
	131 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	132 Move [rbx+220], 40
	133 Goto {137}
	134 Move rdx, 0
	135 Move rcx, rbx
	136 Call Plant.LaunchThreepeater, rcx, rdx
	137 Compare [rbx+164], 50
	138 JumpIfNotEqual {146}
	139 Compare [rbx+112], 43
	140 JumpIfNotEqual {146}
	141 Move rdx, [rbx+52]
	142 Move r9, 0
	143 Move r8, 0
	144 Move rcx, rbx
	145 Call Plant.FindTargetAndFire, rcx, rdx, r8
	146 Compare [rbx+164], 25
	147 JumpIfNotEqual {166}
	148 Compare [rbx+112], 7
	149 JumpIfEqual {161}
	150 Compare [rbx+112], 52
	151 JumpIfEqual {161}
	152 Compare [rbx+112], 28
	153 JumpIfNotEqual {166}
	154 Move rdx, [rbx+52]
	155 Move r9, 0
	156 Move r8, 0
	157 Move rcx, rbx
	158 Call Plant.FindTargetAndFire, rcx, rdx, r8
	159 Move r8, 1
	160 Goto {162}
	161 Move r8, 0
	162 Move rdx, [rbx+52]
	163 Move r9, 0
	164 Move rcx, rbx
	165 Call Plant.FindTargetAndFire, rcx, rdx, r8
	166 Move rdi, stack:0x40
	167 ShiftStack 48
	168 Move rbx, stack:0x0
	169 ShiftStack 8
	170 Return 
	171 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
