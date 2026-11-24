# System.Void UpdateCactus()

- 类：`Plant`
- 汇编行数：315

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,30h
	cmp byte ptr [184EEB66Ah],0
	mov rbx,rcx
	jne short 00000001806B84E9h
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	lea rcx,[184C97230h]
	call 00000001804FEB70h
	lea rcx,[184C97ED8h]
	call 00000001804FEB70h
	lea rcx,[184C963E0h]
	call 00000001804FEB70h
	mov byte ptr [184EEB66Ah],1
	cmp dword ptr [rbx+0DCh],0
	jg near ptr 00000001806B85A8h
	mov [rsp+40h],rdi
	cmp dword ptr [rbx+88h],1Fh
	je near ptr 00000001806B8647h
	cmp dword ptr [rbx+88h],20h
	je near ptr 00000001806B85EEh
	cmp dword ptr [rbx+88h],21h
	je near ptr 00000001806B85AEh
	mov edx,[rbx+34h]
	xor r9d,r9d
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806B0040h
	test rax,rax
	je short 00000001806B85A3h
	movss xmm0,dword ptr [183C33DB4h]
	xor eax,eax
	mov dword ptr [rbx+88h],1Fh
	mov r9d,14h
	mov rdx,[184C97ED8h]
	mov r8d,3
	mov [rsp+28h],rax
	mov rcx,rbx
	movss dword ptr [rsp+20h],xmm0
	call 00000001806B4B80h
	mov r8,[rbx+10h]
	test r8,r8
	je near ptr 00000001806B874Eh
	mov r8,[r8+58h]
	test r8,r8
	je near ptr 00000001806B874Eh
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,3Fh
	call 0000000180002040h
	mov rdi,[rsp+40h]
	add rsp,30h
	pop rbx
	ret
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B874Eh
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle short 00000001806B85A3h
	xor r8d,r8d
	mov dword ptr [rbx+88h],1Eh
	xorps xmm1,xmm1
	mov rcx,rbx
	mov rdi,[rsp+40h]
	add rsp,30h
	pop rbx
	jmp near ptr 00000001806B4C50h
	mov edx,[rbx+34h]
	xor r9d,r9d
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806B0040h
	test rax,rax
	jne short 00000001806B85A3h
	movss xmm0,dword ptr [183C33DB4h]
	mov r9d,14h
	mov dword ptr [rbx+88h],21h
	mov r8d,3
	mov rdx,[184C97230h]
	mov rcx,rbx
	mov [rsp+28h],rax
	movss dword ptr [rsp+20h],xmm0
	call 00000001806B4B80h
	mov rdi,[rsp+40h]
	add rsp,30h
	pop rbx
	ret
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B874Eh
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle near ptr 00000001806B85A3h
	cmp byte ptr [184EEB658h],0
	mov dword ptr [rbx+88h],20h
	mov rdi,[184C963E0h]
	jne short 00000001806B86A2h
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	test rdi,rdi
	je near ptr 00000001806B874Eh
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rdi
	call 0000000182A24E50h
	mov rcx,[rbx+140h]
	mov rdi,rax
	test rcx,rcx
	je short 00000001806B874Eh
	movss xmm1,dword ptr [183C33DBCh]
	xor r9d,r9d
	xor r8d,r8d
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B874Eh
	xor eax,eax
	xorps xmm3,xmm3
	mov [rsp+28h],rax
	xor r8d,r8d
	mov rdx,rdi
	mov [rsp+20h],eax
	call 00000001807C8270h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je short 00000001806B874Eh
	xor edx,edx
	call 00000001807DF5D0h
	test al,al
	je short 00000001806B8739h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B874Eh
	xor r9d,r9d
	xor r8d,r8d
	xorps xmm1,xmm1
	call 00000001807C8740h
	mov rdi,[rsp+40h]
	mov dword ptr [rbx+0A4h],1
	add rsp,30h
	pop rbx
	ret
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -48
	004 Compare [0x184EEB66A], 0
	005 Move rbx, rcx
	006 JumpIfNotEqual {16}
	007 LoadAddress rcx, [0x184C75168]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 LoadAddress rcx, [0x184C97230]
	010 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	011 LoadAddress rcx, [0x184C97ED8]
	012 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	013 LoadAddress rcx, [0x184C963E0]
	014 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	015 Move [0x184EEB66A], 1
	016 Compare [rbx+220], 0
	017 JumpIfGreater {53}
	018 Move stack:0x40, rdi
	019 Compare [rbx+136], 31
	020 JumpIfEqual {96}
	021 Compare [rbx+136], 32
	022 JumpIfEqual {75}
	023 Compare [rbx+136], 33
	024 JumpIfEqual {57}
	025 Move rdx, [rbx+52]
	026 Move r9, 0
	027 Move r8, 0
	028 Move rcx, rbx
	029 Call Plant.FindTargetZombie, rcx, rdx, r8
	030 Compare rax, 0
	031 JumpIfEqual {52}
	032 Move xmm0, [0x183C33DB4]
	033 Move rax, 0
	034 Move [rbx+136], 31
	035 Move r9, 20
	036 Move rdx, "anim_rise"
	037 Move r8, 3
	038 Move stack:0x28, rax
	039 Move rcx, rbx
	040 Move stack:0x20, xmm0
	041 Call Plant.PlayBodyReanim, rcx, rdx, r8, xmm3, stack:0x0
	042 Move r8, [rbx+16]
	043 Compare r8, 0
	044 JumpIfEqual {158}
	045 Move r8, [r8+88]
	046 Compare r8, 0
	047 JumpIfEqual {158}
	048 Move rdx, typeof(Reloaded.Services.IAudioService)
	049 Move rcx, 6
	050 Move r9, 63
	051 Call 0x180002040, rcx, rdx, r8, r9
	052 Move rdi, stack:0x40
	053 ShiftStack 48
	054 Move rbx, stack:0x0
	055 ShiftStack 8
	056 Return 
	057 Move rcx, [rbx+320]
	058 Compare rcx, 0
	059 JumpIfEqual {158}
	060 Move r8, 0
	061 Move rdx, 0
	062 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	063 Compare rax, 0
	064 JumpIfLessOrEqual {52}
	065 Move r8, 0
	066 Move [rbx+136], 30
	067 Move xmm1, 0
	068 Move rcx, rbx
	069 Move rdi, stack:0x40
	070 ShiftStack 48
	071 Move rbx, stack:0x0
	072 ShiftStack 8
	073 Call Plant.PlayIdleAnim, rcx, rdx
	074 Return 
	075 Move rdx, [rbx+52]
	076 Move r9, 0
	077 Move r8, 0
	078 Move rcx, rbx
	079 Call Plant.FindTargetZombie, rcx, rdx, r8
	080 Compare rax, 0
	081 JumpIfNotEqual {52}
	082 Move xmm0, [0x183C33DB4]
	083 Move r9, 20
	084 Move [rbx+136], 33
	085 Move r8, 3
	086 Move rdx, "anim_lower"
	087 Move rcx, rbx
	088 Move stack:0x28, rax
	089 Move stack:0x20, xmm0
	090 Call Plant.PlayBodyReanim, rcx, rdx, r8, xmm3, stack:0x0
	091 Move rdi, stack:0x40
	092 ShiftStack 48
	093 Move rbx, stack:0x0
	094 ShiftStack 8
	095 Return 
	096 Move rcx, [rbx+320]
	097 Compare rcx, 0
	098 JumpIfEqual {158}
	099 Move r8, 0
	100 Move rdx, 0
	101 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	102 Compare rax, 0
	103 JumpIfLessOrEqual {52}
	104 Compare [0x184EEB658], 0
	105 Move [rbx+136], 32
	106 Move rdi, "anim_idlehigh"
	107 JumpIfNotEqual {113}
	108 LoadAddress rcx, [0x184C92A80]
	109 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	110 LoadAddress rcx, [0x184C911F8]
	111 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	112 Move [0x184EEB658], 1
	113 Compare rdi, 0
	114 JumpIfEqual {158}
	115 Move r8, ""
	116 Move r9, 0
	117 Move rdx, "anim_"
	118 Move rcx, rdi
	119 Call String.Replace, rcx, rdx, r8
	120 Move rcx, [rbx+320]
	121 Move rdi, rax
	122 Compare rcx, 0
	123 JumpIfEqual {158}
	124 Move xmm1, [0x183C33DBC]
	125 Move r9, 0
	126 Move r8, 0
	127 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	128 Move rcx, [rbx+320]
	129 Compare rcx, 0
	130 JumpIfEqual {158}
	131 Move rax, 0
	132 Move xmm3, 0
	133 Move stack:0x28, rax
	134 Move r8, 0
	135 Move rdx, rdi
	136 Move stack:0x20, rax
	137 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	138 Move rcx, [rbx+16]
	139 Compare rcx, 0
	140 JumpIfEqual {158}
	141 Move rdx, 0
	142 Call GameplayActivity.IsIZombieLevel, rcx, rdx
	143 Compare rax, 0
	144 JumpIfEqual {152}
	145 Move rcx, [rbx+320]
	146 Compare rcx, 0
	147 JumpIfEqual {158}
	148 Move r9, 0
	149 Move r8, 0
	150 Move xmm1, 0
	151 Call ReloadedCharacterController.SetAnimationRateOnTrack, rcx, rdx, r8
	152 Move rdi, stack:0x40
	153 Move [rbx+164], 1
	154 ShiftStack 48
	155 Move rbx, stack:0x0
	156 ShiftStack 8
	157 Return 
	158 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
