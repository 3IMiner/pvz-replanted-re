# System.Void AttemptSetMarigoldColour(System.String colour)

- 类：`Plant`
- 汇编行数：81

## 反汇编

```asm

Disassembly:
	mov [rsp+8],rbx
	mov [rsp+10h],rsi
	push rdi
	sub rsp,20h
	cmp byte ptr [184EEB677h],0
	mov rsi,rdx
	mov rbx,rcx
	jne short 00000001806ABF01h
	lea rcx,[184C94A90h]
	call 00000001804FEB70h
	mov byte ptr [184EEB677h],1
	mov rcx,[rbx+140h]
	mov rdi,[184C94A90h]
	test rcx,rcx
	je short 00000001806ABF5Bh
	xor r8d,r8d
	mov rdx,rdi
	call 00000001807C9B90h
	xor r8d,r8d
	mov rdx,rsi
	mov rcx,rax
	call 0000000182A1F550h
	test al,al
	jne short 00000001806ABF4Bh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806ABF5Bh
	xor r9d,r9d
	mov r8,rsi
	mov rdx,rdi
	call 00000001807CAE90h
	mov rbx,[rsp+30h]
	mov rsi,[rsp+38h]
	add rsp,20h
	pop rdi
	ret
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x8, rbx
	002 Move stack:0x10, rsi
	003 ShiftStack -8
	004 Move stack:0x0, rdi
	005 ShiftStack -32
	006 Compare [0x184EEB677], 0
	007 Move rsi, rdx
	008 Move rbx, rcx
	009 JumpIfNotEqual {13}
	010 LoadAddress rcx, [0x184C94A90]
	011 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	012 Move [0x184EEB677], 1
	013 Move rcx, [rbx+320]
	014 Move rdi, "anim_face"
	015 Compare rcx, 0
	016 JumpIfEqual {39}
	017 Move r8, 0
	018 Move rdx, rdi
	019 Call ReloadedController.GetImageOverride, rcx, rdx
	020 Move r8, 0
	021 Move rdx, rsi
	022 Move rcx, rax
	023 Call 0x182A1F550, rcx, rdx, r8
	024 Compare rax, 0
	025 JumpIfNotEqual {33}
	026 Move rcx, [rbx+320]
	027 Compare rcx, 0
	028 JumpIfEqual {39}
	029 Move r9, 0
	030 Move r8, rsi
	031 Move rdx, rdi
	032 Call ReloadedController.SetImageOverride, rcx, rdx, r8
	033 Move rbx, stack:0x30
	034 Move rsi, stack:0x38
	035 ShiftStack 32
	036 Move rdi, stack:0x0
	037 ShiftStack 8
	038 Return 
	039 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
