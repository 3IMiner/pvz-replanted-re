# System.Void UpdateCobCannon()

- 类：`Plant`
- 汇编行数：303

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,40h
	cmp byte ptr [184EEB66Eh],0
	mov rbx,rcx
	jne short 00000001806B8BCDh
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	lea rcx,[184C93800h]
	call 00000001804FEB70h
	mov byte ptr [184EEB66Eh],1
	cmp dword ptr [rbx+88h],23h
	mov [rsp+50h],rdi
	je near ptr 00000001806B8D75h
	cmp dword ptr [rbx+88h],24h
	je near ptr 00000001806B8CD4h
	cmp dword ptr [rbx+88h],25h
	je short 00000001806B8C61h
	cmp dword ptr [rbx+88h],26h
	jne short 00000001806B8C56h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B8E36h
	movss xmm1,dword ptr [183C33F94h]
	xor r9d,r9d
	xor r8d,r8d
	call 00000001807C8910h
	test al,al
	je short 00000001806B8C56h
	mov rax,[rbx+10h]
	test rax,rax
	je near ptr 00000001806B8E36h
	mov r8,[rax+58h]
	test r8,r8
	je near ptr 00000001806B8E36h
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,4Ch
	call 0000000180002040h
	mov rdi,[rsp+50h]
	add rsp,40h
	pop rbx
	ret
	mov rax,[rbx+18h]
	mov rdi,[rbx+140h]
	test rax,rax
	je near ptr 00000001806B8E36h
	mov rcx,[184C2AFC0h]
	mov ebx,[rax+1ECh]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806B8C90h
	call 00000001804FEEB0h
	xor r9d,r9d
	lea rcx,[rsp+30h]
	mov r8d,4Bh
	mov edx,ebx
	call 00000001806CB9C0h
	test rdi,rdi
	je near ptr 00000001806B8E36h
	movups xmm0,[rax]
	xor r9d,r9d
	lea rdx,[rsp+30h]
	xor r8d,r8d
	mov rcx,rdi
	movaps [rsp+30h],xmm0
	call 000000018060F880h
	mov rdi,[rsp+50h]
	add rsp,40h
	pop rbx
	ret
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B8E36h
	movss xmm1,dword ptr [183C33C40h]
	xor r9d,r9d
	xor r8d,r8d
	call 00000001807C8910h
	test al,al
	je short 00000001806B8D2Ch
	mov rax,[rbx+10h]
	test rax,rax
	je near ptr 00000001806B8E36h
	mov r8,[rax+58h]
	test r8,r8
	je near ptr 00000001806B8E36h
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,40h
	call 0000000180002040h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B8E36h
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle near ptr 00000001806B8C56h
	movss xmm1,dword ptr [183C33DB4h]
	xor r8d,r8d
	mov rcx,rbx
	mov dword ptr [rbx+88h],25h
	mov rdi,[rsp+50h]
	add rsp,40h
	pop rbx
	jmp near ptr 00000001806B4C50h
	cmp dword ptr [rbx+0A0h],0
	jne near ptr 00000001806B8C56h
	cmp byte ptr [184EEB658h],0
	mov dword ptr [rbx+88h],24h
	mov rdi,[184C93800h]
	jne short 00000001806B8DBBh
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	test rdi,rdi
	je short 00000001806B8E36h
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rdi
	call 0000000182A24E50h
	mov rcx,[rbx+140h]
	mov rdi,rax
	test rcx,rcx
	je short 00000001806B8E36h
	movss xmm1,dword ptr [183C33DBCh]
	xor r9d,r9d
	xor r8d,r8d
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B8E36h
	movss xmm3,dword ptr [183C33DB4h]
	xor r8d,r8d
	mov qword ptr [rsp+28h],0
	mov rdx,rdi
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	mov rdi,[rsp+50h]
	add rsp,40h
	pop rbx
	ret
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -64
	004 Compare [0x184EEB66E], 0
	005 Move rbx, rcx
	006 JumpIfNotEqual {14}
	007 LoadAddress rcx, [0x184C2AFC0]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 LoadAddress rcx, [0x184C75168]
	010 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	011 LoadAddress rcx, [0x184C93800]
	012 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	013 Move [0x184EEB66E], 1
	014 Compare [rbx+136], 35
	015 Move stack:0x50, rdi
	016 JumpIfEqual {112}
	017 Compare [rbx+136], 36
	018 JumpIfEqual {75}
	019 Compare [rbx+136], 37
	020 JumpIfEqual {47}
	021 Compare [rbx+136], 38
	022 JumpIfNotEqual {42}
	023 Move rcx, [rbx+320]
	024 Compare rcx, 0
	025 JumpIfEqual {152}
	026 Move xmm1, [0x183C33F94]
	027 Move r9, 0
	028 Move r8, 0
	029 Call ReloadedCharacterController.ShouldTriggerTimedEvent, rcx, rdx, r8
	030 Compare rax, 0
	031 JumpIfEqual {42}
	032 Move rax, [rbx+16]
	033 Compare rax, 0
	034 JumpIfEqual {152}
	035 Move r8, [rax+88]
	036 Compare r8, 0
	037 JumpIfEqual {152}
	038 Move rdx, typeof(Reloaded.Services.IAudioService)
	039 Move rcx, 6
	040 Move r9, 76
	041 Call 0x180002040, rcx, rdx, r8, r9
	042 Move rdi, stack:0x50
	043 ShiftStack 64
	044 Move rbx, stack:0x0
	045 ShiftStack 8
	046 Return 
	047 Move rax, [rbx+24]
	048 Move rdi, [rbx+320]
	049 Compare rax, 0
	050 JumpIfEqual {152}
	051 Move rcx, typeof(Reloaded.Gameplay.Common)
	052 Move rbx, [rax+492]
	053 Compare [rcx+228], 0
	054 JumpIfNotEqual {56}
	055 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	056 Move r9, 0
	057 LoadAddress rcx, stack:0x30
	058 Move r8, 75
	059 Move rdx, rbx
	060 Call Common.GetFlashingColor, rcx, rdx, r8
	061 Compare rdi, 0
	062 JumpIfEqual {152}
	063 Move xmm0, [rax]
	064 Move r9, 0
	065 LoadAddress rdx, stack:0x30
	066 Move r8, 0
	067 Move rcx, rdi
	068 Move stack:0x30, xmm0
	069 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	070 Move rdi, stack:0x50
	071 ShiftStack 64
	072 Move rbx, stack:0x0
	073 ShiftStack 8
	074 Return 
	075 Move rcx, [rbx+320]
	076 Compare rcx, 0
	077 JumpIfEqual {152}
	078 Move xmm1, [0x183C33C40]
	079 Move r9, 0
	080 Move r8, 0
	081 Call ReloadedCharacterController.ShouldTriggerTimedEvent, rcx, rdx, r8
	082 Compare rax, 0
	083 JumpIfEqual {94}
	084 Move rax, [rbx+16]
	085 Compare rax, 0
	086 JumpIfEqual {152}
	087 Move r8, [rax+88]
	088 Compare r8, 0
	089 JumpIfEqual {152}
	090 Move rdx, typeof(Reloaded.Services.IAudioService)
	091 Move rcx, 6
	092 Move r9, 64
	093 Call 0x180002040, rcx, rdx, r8, r9
	094 Move rcx, [rbx+320]
	095 Compare rcx, 0
	096 JumpIfEqual {152}
	097 Move r8, 0
	098 Move rdx, 0
	099 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	100 Compare rax, 0
	101 JumpIfLessOrEqual {42}
	102 Move xmm1, [0x183C33DB4]
	103 Move r8, 0
	104 Move rcx, rbx
	105 Move [rbx+136], 37
	106 Move rdi, stack:0x50
	107 ShiftStack 64
	108 Move rbx, stack:0x0
	109 ShiftStack 8
	110 Call Plant.PlayIdleAnim, rcx, rdx
	111 Return 
	112 Compare [rbx+160], 0
	113 JumpIfNotEqual {42}
	114 Compare [0x184EEB658], 0
	115 Move [rbx+136], 36
	116 Move rdi, "anim_charge"
	117 JumpIfNotEqual {123}
	118 LoadAddress rcx, [0x184C92A80]
	119 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	120 LoadAddress rcx, [0x184C911F8]
	121 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	122 Move [0x184EEB658], 1
	123 Compare rdi, 0
	124 JumpIfEqual {152}
	125 Move r8, ""
	126 Move r9, 0
	127 Move rdx, "anim_"
	128 Move rcx, rdi
	129 Call String.Replace, rcx, rdx, r8
	130 Move rcx, [rbx+320]
	131 Move rdi, rax
	132 Compare rcx, 0
	133 JumpIfEqual {152}
	134 Move xmm1, [0x183C33DBC]
	135 Move r9, 0
	136 Move r8, 0
	137 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	138 Move rcx, [rbx+320]
	139 Compare rcx, 0
	140 JumpIfEqual {152}
	141 Move xmm3, [0x183C33DB4]
	142 Move r8, 0
	143 Move stack:0x28, 0
	144 Move rdx, rdi
	145 Move stack:0x20, 3
	146 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	147 Move rdi, stack:0x50
	148 ShiftStack 64
	149 Move rbx, stack:0x0
	150 ShiftStack 8
	151 Return 
	152 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
