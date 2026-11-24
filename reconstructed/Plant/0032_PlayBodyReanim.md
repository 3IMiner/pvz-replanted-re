# System.Void PlayBodyReanim(System.String theTrackName, Reloaded.Gameplay.ReanimLoopType theLoopType, System.Int32 theBlendTime, System.Single theAnimRate)

- 类：`Plant`
- 汇编行数：106

## 反汇编

```asm

Disassembly:
	mov [rsp+8],rbx
	mov [rsp+10h],rbp
	mov [rsp+18h],rsi
	push rdi
	sub rsp,30h
	cmp byte ptr [184EEB658h],0
	mov esi,r9d
	mov ebp,r8d
	mov rdi,rdx
	mov rbx,rcx
	jne short 00000001806B4BC8h
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	test rdi,rdi
	je short 00000001806B4C49h
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rdi
	call 0000000182A24E50h
	mov rdi,rax
	test esi,esi
	jle short 00000001806B4C0Bh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B4C49h
	movd xmm1,esi
	xor r9d,r9d
	cvtdq2ps xmm1,xmm1
	xor r8d,r8d
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B4C49h
	movss xmm3,dword ptr [rsp+60h]
	xor r8d,r8d
	mov qword ptr [rsp+68h],0
	mov rdx,rdi
	mov [rsp+60h],ebp
	mov rbx,[rsp+40h]
	mov rbp,[rsp+48h]
	mov rsi,[rsp+50h]
	add rsp,30h
	pop rdi
	jmp near ptr 00000001807C8270h
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x8, rbx
	002 Move stack:0x10, rbp
	003 Move stack:0x18, rsi
	004 ShiftStack -8
	005 Move stack:0x0, rdi
	006 ShiftStack -48
	007 Compare [0x184EEB658], 0
	008 Move rsi, r9
	009 Move rbp, r8
	010 Move rdi, rdx
	011 Move rbx, rcx
	012 JumpIfNotEqual {18}
	013 LoadAddress rcx, [0x184C92A80]
	014 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	015 LoadAddress rcx, [0x184C911F8]
	016 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	017 Move [0x184EEB658], 1
	018 Compare rdi, 0
	019 JumpIfEqual {52}
	020 Move r8, ""
	021 Move r9, 0
	022 Move rdx, "anim_"
	023 Move rcx, rdi
	024 Call String.Replace, rcx, rdx, r8
	025 Move rdi, rax
	026 Compare rsi, 0
	027 JumpIfLessOrEqual {36}
	028 Move rcx, [rbx+320]
	029 Compare rcx, 0
	030 JumpIfEqual {52}
	031 Move xmm1, rsi
	032 Move r9, 0
	033 Move xmm1, xmm1
	034 Move r8, 0
	035 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	036 Move rcx, [rbx+320]
	037 Compare rcx, 0
	038 JumpIfEqual {52}
	039 Move xmm3, stack:0x60
	040 Move r8, 0
	041 Move stack:0x68, 0
	042 Move rdx, rdi
	043 Move stack:0x60, rbp
	044 Move rbx, stack:0x40
	045 Move rbp, stack:0x48
	046 Move rsi, stack:0x50
	047 ShiftStack 48
	048 Move rdi, stack:0x0
	049 ShiftStack 8
	050 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	051 Return 
	052 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
