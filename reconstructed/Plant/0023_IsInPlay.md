# System.Boolean IsInPlay()

- 类：`Plant`
- 汇编行数：68

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,20h
	cmp qword ptr [rcx+18h],0
	mov rbx,rcx
	je short 00000001806B223Bh
	cmp byte ptr [rcx+137h],0
	je short 00000001806B223Bh
	mov rcx,[rcx+10h]
	test rcx,rcx
	je short 00000001806B2243h
	xor edx,edx
	call 00000001807E3010h
	cmp eax,2Bh
	je short 00000001806B223Bh
	mov rcx,[rbx+10h]
	test rcx,rcx
	je short 00000001806B2243h
	xor edx,edx
	call 00000001807E3010h
	cmp eax,32h
	je short 00000001806B223Bh
	mov al,1
	add rsp,20h
	pop rbx
	ret
	xor al,al
	add rsp,20h
	pop rbx
	ret
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -32
	004 Compare [rcx+24], 0
	005 Move rbx, rcx
	006 JumpIfEqual {28}
	007 Compare [rcx+311], 0
	008 JumpIfEqual {28}
	009 Move rcx, [rcx+16]
	010 Compare rcx, 0
	011 JumpIfEqual {33}
	012 Move rdx, 0
	013 Call GameplayActivity.get_GameMode, rcx, rdx
	014 Compare rax, 43
	015 JumpIfEqual {28}
	016 Move rcx, [rbx+16]
	017 Compare rcx, 0
	018 JumpIfEqual {33}
	019 Move rdx, 0
	020 Call GameplayActivity.get_GameMode, rcx, rdx
	021 Compare rax, 50
	022 JumpIfEqual {28}
	023 Move rax, 1
	024 ShiftStack 32
	025 Move rbx, stack:0x0
	026 ShiftStack 8
	027 Return rax
	028 Move rax, 0
	029 ShiftStack 32
	030 Move rbx, stack:0x0
	031 ShiftStack 8
	032 Return rax
	033 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
