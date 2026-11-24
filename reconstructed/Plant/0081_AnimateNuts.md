# System.Void AnimateNuts()

- 类：`Plant`
- 汇编行数：367

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,60h
	cmp byte ptr [184EEB65Eh],0
	mov rbx,rcx
	jne short 00000001806AB52Dh
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C94A90h]
	call 00000001804FEB70h
	lea rcx,[184C5E980h]
	call 00000001804FEB70h
	lea rcx,[184C5E6F0h]
	call 00000001804FEB70h
	lea rcx,[184C95FA8h]
	call 00000001804FEB70h
	lea rcx,[184C5E8A8h]
	call 00000001804FEB70h
	lea rcx,[184C5E7C8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB65Eh],1
	cmp dword ptr [rbx+70h],3
	mov [rsp+70h],rbp
	mov [rsp+78h],rsi
	mov [rsp+80h],rdi
	movaps [rsp+50h],xmm6
	movaps [rsp+40h],xmm7
	movaps [rsp+30h],xmm8
	je short 00000001806AB591h
	cmp dword ptr [rbx+70h],17h
	jne near ptr 00000001806AB7BBh
	movss xmm6,dword ptr [rbx+24h]
	movss xmm8,dword ptr [183C33DACh]
	mov rbp,[184C5E6F0h]
	addss xmm6,xmm8
	mov rsi,[184C5E7C8h]
	mov rdi,[184C95FA8h]
	subss xmm6,dword ptr [183C33FC4h]
	jmp short 00000001806AB5B9h
	movss xmm6,dword ptr [rbx+24h]
	movss xmm8,dword ptr [183C33DACh]
	mov rbp,[184C5E8A8h]
	addss xmm6,xmm8
	mov rsi,[184C5E980h]
	mov rdi,[184C94A90h]
	movss xmm7,dword ptr [rbx+20h]
	addss xmm7,dword ptr [183C33DC4h]
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806AB7F3h
	xor r8d,r8d
	mov rdx,rdi
	call 00000001807C9B90h
	mov r9,rax
	mov eax,55555556h
	imul dword ptr [rbx+90h]
	mov ecx,edx
	shr ecx,1Fh
	add edx,ecx
	cmp [rbx+8Ch],edx
	jl short 00000001806AB666h
	mov ecx,[rbx+90h]
	mov eax,55555556h
	add ecx,ecx
	imul ecx
	mov eax,edx
	shr eax,1Fh
	add edx,eax
	cmp [rbx+8Ch],edx
	jl short 00000001806AB63Fh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806AB7F3h
	xor r9d,r9d
	xor r8d,r8d
	mov rdx,rdi
	call 00000001807CAE90h
	jmp near ptr 00000001806AB6C7h
	xor r8d,r8d
	mov rdx,rbp
	mov rcx,r9
	call 0000000182A27F50h
	test al,al
	je short 00000001806AB6C7h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806AB7F3h
	mov r8,rbp
	jmp short 00000001806AB68Bh
	xor r8d,r8d
	mov rdx,rsi
	mov rcx,r9
	call 0000000182A27F50h
	test al,al
	je short 00000001806AB6C7h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806AB7F3h
	mov r8,rsi
	xor r9d,r9d
	mov rdx,rdi
	call 00000001807CAE90h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806AB7F3h
	mov r9d,[rbx+38h]
	movaps xmm2,xmm6
	add r9d,4
	mov qword ptr [rsp+28h],0
	movaps xmm1,xmm7
	mov dword ptr [rsp+20h],24h
	call 00000001807D9B50h
	cmp qword ptr [rbx+18h],0
	je near ptr 00000001806AB7BBh
	cmp byte ptr [rbx+137h],0
	je near ptr 00000001806AB7BBh
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806AB7F3h
	xor edx,edx
	call 00000001807E3010h
	cmp eax,2Bh
	je near ptr 00000001806AB7BBh
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806AB7F3h
	xor edx,edx
	call 00000001807E3010h
	cmp eax,32h
	je near ptr 00000001806AB7BBh
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806AB7F3h
	xor edx,edx
	call 00000001807DF5D0h
	test al,al
	jne near ptr 00000001806AB7BBh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806AB7F3h
	cmp dword ptr [rbx+100h],0
	jg near ptr 00000001806AB7E3h
	xor r8d,r8d
	xor edx,edx
	call 00000001807C78A0h
	movaps xmm1,xmm0
	movss xmm0,dword ptr [183C33C4Ch]
	comiss xmm0,xmm1
	jbe short 00000001806AB7BBh
	cmp dword ptr [rbx+128h],2
	je short 00000001806AB7BBh
	mov rcx,[184C2AFC0h]
	mov rbx,[rbx+140h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806AB791h
	call 00000001804FEEB0h
	movss xmm1,dword ptr [183C33DB8h]
	xor r8d,r8d
	movaps xmm0,xmm8
	call 00000001806CBD40h
	test rbx,rbx
	je short 00000001806AB7F3h
	xor r9d,r9d
	movaps xmm1,xmm0
	xor r8d,r8d
	mov rcx,rbx
	call 00000001807C8740h
	movaps xmm8,[rsp+30h]
	movaps xmm7,[rsp+40h]
	movaps xmm6,[rsp+50h]
	mov rdi,[rsp+80h]
	mov rsi,[rsp+78h]
	mov rbp,[rsp+70h]
	add rsp,60h
	pop rbx
	ret
	movss xmm1,dword ptr [183C33F90h]
	xor r9d,r9d
	xor r8d,r8d
	jmp short 00000001806AB7B6h
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -96
	004 Compare [0x184EEB65E], 0
	005 Move rbx, rcx
	006 JumpIfNotEqual {22}
	007 LoadAddress rcx, [0x184C2AFC0]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 LoadAddress rcx, [0x184C94A90]
	010 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	011 LoadAddress rcx, [0x184C5E980]
	012 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	013 LoadAddress rcx, [0x184C5E6F0]
	014 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	015 LoadAddress rcx, [0x184C95FA8]
	016 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	017 LoadAddress rcx, [0x184C5E8A8]
	018 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	019 LoadAddress rcx, [0x184C5E7C8]
	020 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	021 Move [0x184EEB65E], 1
	022 Compare [rbx+112], 3
	023 Move stack:0x70, rbp
	024 Move stack:0x78, rsi
	025 Move stack:0x80, rdi
	026 Move stack:0x50, xmm6
	027 Move stack:0x40, xmm7
	028 Move stack:0x30, xmm8
	029 JumpIfEqual {40}
	030 Compare [rbx+112], 23
	031 JumpIfNotEqual {168}
	032 Move xmm6, [rbx+36]
	033 Move xmm8, [0x183C33DAC]
	034 Move rbp, "IMAGE_REANIM_TALLNUT_CRACKED1"
	035 Add xmm6, xmm6, xmm8
	036 Move rsi, "IMAGE_REANIM_TALLNUT_CRACKED2"
	037 Move rdi, "anim_idle"
	038 Subtract xmm6, xmm6, [0x183C33FC4]
	039 Goto {46}
	040 Move xmm6, [rbx+36]
	041 Move xmm8, [0x183C33DAC]
	042 Move rbp, "IMAGE_REANIM_WALLNUT_CRACKED1"
	043 Add xmm6, xmm6, xmm8
	044 Move rsi, "IMAGE_REANIM_WALLNUT_CRACKED2"
	045 Move rdi, "anim_face"
	046 Move xmm7, [rbx+32]
	047 Add xmm7, xmm7, [0x183C33DC4]
	048 Move rcx, [rbx+320]
	049 Compare rcx, 0
	050 JumpIfEqual {182}
	051 Move r8, 0
	052 Move rdx, rdi
	053 Call ReloadedController.GetImageOverride, rcx, rdx
	054 Move r9, rax
	055 Move rax, 0x55555556
	056 NotImplemented "imul dword ptr [rbx+90h]"
	057 Move rcx, rdx
	058 ShiftRight rcx, 31
	059 Add rdx, rdx, rcx
	060 Compare [rbx+140], rdx
	061 JumpIfLess {90}
	062 Move rcx, [rbx+144]
	063 Move rax, 0x55555556
	064 Add rcx, rcx, rcx
	065 NotImplemented "imul ecx"
	066 Move rax, rdx
	067 ShiftRight rax, 31
	068 Add rdx, rdx, rax
	069 Compare [rbx+140], rdx
	070 JumpIfLess {79}
	071 Move rcx, [rbx+320]
	072 Compare rcx, 0
	073 JumpIfEqual {182}
	074 Move r9, 0
	075 Move r8, 0
	076 Move rdx, rdi
	077 Call ReloadedController.SetImageOverride, rcx, rdx, r8
	078 Goto {113}
	079 Move r8, 0
	080 Move rdx, rbp
	081 Move rcx, r9
	082 Call String.op_Inequality, rcx, rdx, r8
	083 Compare rax, 0
	084 JumpIfEqual {113}
	085 Move rcx, [rbx+320]
	086 Compare rcx, 0
	087 JumpIfEqual {182}
	088 Move r8, rbp
	089 Goto {100}
	090 Move r8, 0
	091 Move rdx, rsi
	092 Move rcx, r9
	093 Call String.op_Inequality, rcx, rdx, r8
	094 Compare rax, 0
	095 JumpIfEqual {113}
	096 Move rcx, [rbx+320]
	097 Compare rcx, 0
	098 JumpIfEqual {182}
	099 Move r8, rsi
	100 Move r9, 0
	101 Move rdx, rdi
	102 Call ReloadedController.SetImageOverride, rcx, rdx, r8
	103 Move rcx, [rbx+16]
	104 Compare rcx, 0
	105 JumpIfEqual {182}
	106 Move r9, [rbx+56]
	107 Move xmm2, xmm6
	108 Add r9, r9, 4
	109 Move stack:0x28, 0
	110 Move xmm1, xmm7
	111 Move stack:0x20, 36
	112 Call GameplayActivity.AddTodParticle, rcx, xmm1, r8, r9, stack:0x0
	113 Compare [rbx+24], 0
	114 JumpIfEqual {168}
	115 Compare [rbx+311], 0
	116 JumpIfEqual {168}
	117 Move rcx, [rbx+16]
	118 Compare rcx, 0
	119 JumpIfEqual {182}
	120 Move rdx, 0
	121 Call GameplayActivity.get_GameMode, rcx, rdx
	122 Compare rax, 43
	123 JumpIfEqual {168}
	124 Move rcx, [rbx+16]
	125 Compare rcx, 0
	126 JumpIfEqual {182}
	127 Move rdx, 0
	128 Call GameplayActivity.get_GameMode, rcx, rdx
	129 Compare rax, 50
	130 JumpIfEqual {168}
	131 Move rcx, [rbx+16]
	132 Compare rcx, 0
	133 JumpIfEqual {182}
	134 Move rdx, 0
	135 Call GameplayActivity.IsIZombieLevel, rcx, rdx
	136 Compare rax, 0
	137 JumpIfNotEqual {168}
	138 Move rcx, [rbx+320]
	139 Compare rcx, 0
	140 JumpIfEqual {182}
	141 Compare [rbx+256], 0
	142 JumpIfGreater {178}
	143 Move r8, 0
	144 Move rdx, 0
	145 Call ReloadedCharacterController.GetAnimationRateOnTrack, rcx, rdx
	146 Move xmm1, xmm0
	147 Move xmm0, [0x183C33C4C]
	148 Compare xmm0, xmm1
	149 JumpIfLessOrEqual {168}
	150 Compare [rbx+296], 2
	151 JumpIfEqual {168}
	152 Move rcx, typeof(Reloaded.Gameplay.Common)
	153 Move rbx, [rbx+320]
	154 Compare [rcx+228], 0
	155 JumpIfNotEqual {157}
	156 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	157 Move xmm1, [0x183C33DB8]
	158 Move r8, 0
	159 Move xmm0, xmm8
	160 Call Common.RandRangeFloat, xmm0, xmm1, r8
	161 Compare rbx, 0
	162 JumpIfEqual {182}
	163 Move r9, 0
	164 Move xmm1, xmm0
	165 Move r8, 0
	166 Move rcx, rbx
	167 Call ReloadedCharacterController.SetAnimationRateOnTrack, rcx, rdx, r8
	168 Move xmm8, stack:0x30
	169 Move xmm7, stack:0x40
	170 Move xmm6, stack:0x50
	171 Move rdi, stack:0x80
	172 Move rsi, stack:0x78
	173 Move rbp, stack:0x70
	174 ShiftStack 96
	175 Move rbx, stack:0x0
	176 ShiftStack 8
	177 Return 
	178 Move xmm1, [0x183C33F90]
	179 Move r9, 0
	180 Move r8, 0
	181 Goto {167}
	182 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
