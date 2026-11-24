# System.Void PlayIdleAnim(System.Single theRate)

- 类：`Plant`
- 汇编行数：161

## 反汇编

```asm

Disassembly:
	mov [rsp+8],rbx
	push rdi
	sub rsp,40h
	cmp byte ptr [184EEB679h],0
	mov rbx,rcx
	movaps [rsp+30h],xmm6
	movaps xmm6,xmm1
	jne short 00000001806B4C8Dh
	lea rcx,[184C2D478h]
	call 00000001804FEB70h
	lea rcx,[184C95FA8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB679h],1
	mov rcx,[184C2D478h]
	mov rdi,[rbx+140h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806B4CA9h
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rdi
	call 0000000183832770h
	test al,al
	jne near ptr 00000001806B4D83h
	cmp [184EEB658h],al
	mov rdi,[184C95FA8h]
	jne short 00000001806B4CECh
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	test rdi,rdi
	je near ptr 00000001806B4D93h
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rdi
	call 0000000182A24E50h
	mov rcx,[rbx+140h]
	mov rdi,rax
	test rcx,rcx
	je short 00000001806B4D93h
	movss xmm1,dword ptr [183C33DBCh]
	xor r9d,r9d
	xor r8d,r8d
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B4D93h
	xor eax,eax
	movaps xmm3,xmm6
	mov [rsp+28h],rax
	xor r8d,r8d
	mov rdx,rdi
	mov [rsp+20h],eax
	call 00000001807C8270h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je short 00000001806B4D93h
	xor edx,edx
	call 00000001807DF5D0h
	test al,al
	je short 00000001806B4D83h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B4D93h
	xor r9d,r9d
	xor r8d,r8d
	xorps xmm1,xmm1
	call 00000001807C8740h
	mov rbx,[rsp+50h]
	movaps xmm6,[rsp+30h]
	add rsp,40h
	pop rdi
	ret
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x8, rbx
	002 ShiftStack -8
	003 Move stack:0x0, rdi
	004 ShiftStack -64
	005 Compare [0x184EEB679], 0
	006 Move rbx, rcx
	007 Move stack:0x30, xmm6
	008 Move xmm6, xmm1
	009 JumpIfNotEqual {15}
	010 LoadAddress rcx, [0x184C2D478]
	011 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	012 LoadAddress rcx, [0x184C95FA8]
	013 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	014 Move [0x184EEB679], 1
	015 Move rcx, typeof(UnityEngine.Object)
	016 Move rdi, [rbx+320]
	017 Compare [rcx+228], 0
	018 JumpIfNotEqual {20}
	019 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	020 Move r8, 0
	021 Move rdx, 0
	022 Move rcx, rdi
	023 Call Object.op_Equality, rcx, rdx, r8
	024 Compare rax, 0
	025 JumpIfNotEqual {73}
	026 Compare [0x184EEB658], rax
	027 Move rdi, "anim_idle"
	028 JumpIfNotEqual {34}
	029 LoadAddress rcx, [0x184C92A80]
	030 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	031 LoadAddress rcx, [0x184C911F8]
	032 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	033 Move [0x184EEB658], 1
	034 Compare rdi, 0
	035 JumpIfEqual {79}
	036 Move r8, ""
	037 Move r9, 0
	038 Move rdx, "anim_"
	039 Move rcx, rdi
	040 Call String.Replace, rcx, rdx, r8
	041 Move rcx, [rbx+320]
	042 Move rdi, rax
	043 Compare rcx, 0
	044 JumpIfEqual {79}
	045 Move xmm1, [0x183C33DBC]
	046 Move r9, 0
	047 Move r8, 0
	048 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	049 Move rcx, [rbx+320]
	050 Compare rcx, 0
	051 JumpIfEqual {79}
	052 Move rax, 0
	053 Move xmm3, xmm6
	054 Move stack:0x28, rax
	055 Move r8, 0
	056 Move rdx, rdi
	057 Move stack:0x20, rax
	058 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	059 Move rcx, [rbx+16]
	060 Compare rcx, 0
	061 JumpIfEqual {79}
	062 Move rdx, 0
	063 Call GameplayActivity.IsIZombieLevel, rcx, rdx
	064 Compare rax, 0
	065 JumpIfEqual {73}
	066 Move rcx, [rbx+320]
	067 Compare rcx, 0
	068 JumpIfEqual {79}
	069 Move r9, 0
	070 Move r8, 0
	071 Move xmm1, 0
	072 Call ReloadedCharacterController.SetAnimationRateOnTrack, rcx, rdx, r8
	073 Move rbx, stack:0x50
	074 Move xmm6, stack:0x30
	075 ShiftStack 64
	076 Move rdi, stack:0x0
	077 ShiftStack 8
	078 Return 
	079 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
