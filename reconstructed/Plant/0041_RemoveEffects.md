# System.Void RemoveEffects()

- 类：`Plant`
- 汇编行数：141

## 反汇编

```asm

Disassembly:
	mov [rsp+8],rbx
	push rdi
	sub rsp,20h
	cmp byte ptr [184EEB671h],0
	mov rbx,rcx
	jne short 00000001806B4E59h
	lea rcx,[184C2D478h]
	call 00000001804FEB70h
	mov byte ptr [184EEB671h],1
	mov rcx,[184C2D478h]
	mov rdi,[rbx+10h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806B4E72h
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rdi
	call 0000000183832770h
	test al,al
	jne near ptr 00000001806B4F30h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B4F3Bh
	mov edx,[rbx+0D8h]
	xor r8d,r8d
	call 000000018060F880h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B4F3Bh
	mov edx,[rbx+0E0h]
	xor r8d,r8d
	call 00000001807E14A0h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je short 00000001806B4F3Bh
	mov edx,[rbx+0E4h]
	xor r8d,r8d
	call 00000001807E14A0h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je short 00000001806B4F3Bh
	mov edx,[rbx+0E8h]
	xor r8d,r8d
	call 00000001807E14A0h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je short 00000001806B4F3Bh
	mov edx,[rbx+0ECh]
	xor r8d,r8d
	call 00000001807E14A0h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je short 00000001806B4F3Bh
	mov edx,[rbx+0F0h]
	xor r8d,r8d
	call 00000001807E14A0h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je short 00000001806B4F3Bh
	mov edx,[rbx+0F8h]
	xor r8d,r8d
	call 00000001807E14A0h
	mov rbx,[rsp+30h]
	add rsp,20h
	pop rdi
	ret
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x8, rbx
	002 ShiftStack -8
	003 Move stack:0x0, rdi
	004 ShiftStack -32
	005 Compare [0x184EEB671], 0
	006 Move rbx, rcx
	007 JumpIfNotEqual {11}
	008 LoadAddress rcx, [0x184C2D478]
	009 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	010 Move [0x184EEB671], 1
	011 Move rcx, typeof(UnityEngine.Object)
	012 Move rdi, [rbx+16]
	013 Compare [rcx+228], 0
	014 JumpIfNotEqual {16}
	015 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	016 Move r8, 0
	017 Move rdx, 0
	018 Move rcx, rdi
	019 Call Object.op_Equality, rcx, rdx, r8
	020 Compare rax, 0
	021 JumpIfNotEqual {64}
	022 Move rcx, [rbx+16]
	023 Compare rcx, 0
	024 JumpIfEqual {69}
	025 Move rdx, [rbx+216]
	026 Move r8, 0
	027 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	028 Move rcx, [rbx+16]
	029 Compare rcx, 0
	030 JumpIfEqual {69}
	031 Move rdx, [rbx+224]
	032 Move r8, 0
	033 Call GameplayActivity.RemoveReanimation, rcx, rdx
	034 Move rcx, [rbx+16]
	035 Compare rcx, 0
	036 JumpIfEqual {69}
	037 Move rdx, [rbx+228]
	038 Move r8, 0
	039 Call GameplayActivity.RemoveReanimation, rcx, rdx
	040 Move rcx, [rbx+16]
	041 Compare rcx, 0
	042 JumpIfEqual {69}
	043 Move rdx, [rbx+232]
	044 Move r8, 0
	045 Call GameplayActivity.RemoveReanimation, rcx, rdx
	046 Move rcx, [rbx+16]
	047 Compare rcx, 0
	048 JumpIfEqual {69}
	049 Move rdx, [rbx+236]
	050 Move r8, 0
	051 Call GameplayActivity.RemoveReanimation, rcx, rdx
	052 Move rcx, [rbx+16]
	053 Compare rcx, 0
	054 JumpIfEqual {69}
	055 Move rdx, [rbx+240]
	056 Move r8, 0
	057 Call GameplayActivity.RemoveReanimation, rcx, rdx
	058 Move rcx, [rbx+16]
	059 Compare rcx, 0
	060 JumpIfEqual {69}
	061 Move rdx, [rbx+248]
	062 Move r8, 0
	063 Call GameplayActivity.RemoveReanimation, rcx, rdx
	064 Move rbx, stack:0x30
	065 ShiftStack 32
	066 Move rdi, stack:0x0
	067 ShiftStack 8
	068 Return 
	069 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
