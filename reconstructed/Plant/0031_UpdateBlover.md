# System.Void UpdateBlover()

- 类：`Plant`
- 汇编行数：97

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,20h
	cmp byte ptr [184EEB669h],0
	mov rbx,rcx
	jne short 00000001806B7CC5h
	lea rcx,[184C2A910h]
	call 00000001804FEB70h
	mov byte ptr [184EEB669h],1
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B7D3Eh
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle short 00000001806B7D17h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B7D3Eh
	xor r8d,r8d
	xor edx,edx
	call 00000001807C76C0h
	test eax,eax
	je short 00000001806B7D17h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B7D3Eh
	mov rdx,[184C2A910h]
	xor r9d,r9d
	xor r8d,r8d
	call 00000001807C8230h
	cmp dword ptr [rbx+88h],2
	je short 00000001806B7D38h
	cmp dword ptr [rbx+9Ch],0
	jne short 00000001806B7D38h
	xor edx,edx
	mov rcx,rbx
	add rsp,20h
	pop rbx
	jmp near ptr 00000001806AD780h
	add rsp,20h
	pop rbx
	ret
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -32
	004 Compare [0x184EEB669], 0
	005 Move rbx, rcx
	006 JumpIfNotEqual {10}
	007 LoadAddress rcx, [0x184C2A910]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 Move [0x184EEB669], 1
	010 Move rcx, [rbx+320]
	011 Compare rcx, 0
	012 JumpIfEqual {48}
	013 Move r8, 0
	014 Move rdx, 0
	015 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	016 Compare rax, 0
	017 JumpIfLessOrEqual {33}
	018 Move rcx, [rbx+320]
	019 Compare rcx, 0
	020 JumpIfEqual {48}
	021 Move r8, 0
	022 Move rdx, 0
	023 Call ReloadedCharacterController.GetAnimLoopType, rcx, rdx
	024 Compare rax, 0
	025 JumpIfEqual {33}
	026 Move rcx, [rbx+320]
	027 Compare rcx, 0
	028 JumpIfEqual {48}
	029 Move rdx, "loop"
	030 Move r9, 0
	031 Move r8, 0
	032 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, r8
	033 Compare [rbx+136], 2
	034 JumpIfEqual {44}
	035 Compare [rbx+156], 0
	036 JumpIfNotEqual {44}
	037 Move rdx, 0
	038 Move rcx, rbx
	039 ShiftStack 32
	040 Move rbx, stack:0x0
	041 ShiftStack 8
	042 Call Plant.DoSpecial, rcx, rdx
	043 Return 
	044 ShiftStack 32
	045 Move rbx, stack:0x0
	046 ShiftStack 8
	047 Return 
	048 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
