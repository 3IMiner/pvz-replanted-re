# Reloaded.Gameplay.MagnetItem GetFreeMagnetItem()

- 类：`Plant`
- 汇编行数：87

## 反汇编

```asm

Disassembly:
	sub rsp,28h
	cmp dword ptr [rcx+70h],2Dh
	mov r8,[rcx+118h]
	je short 00000001806B13D6h
	test r8,r8
	je short 00000001806B1429h
	cmp dword ptr [r8+18h],0
	jbe short 00000001806B142Fh
	mov rax,[r8+20h]
	add rsp,28h
	ret
	nop word ptr [rax+rax]
	xor eax,eax
	lea rdx,[r8+20h]
	mov ecx,eax
	test r8,r8
	je short 00000001806B1429h
	cmp eax,[r8+18h]
	jae short 00000001806B142Fh
	mov r9,[rdx]
	test r9,r9
	je short 00000001806B1429h
	cmp dword ptr [r9+20h],0
	je short 00000001806B1418h
	inc eax
	inc rcx
	add rdx,8
	cmp rcx,5
	jl short 00000001806B13EDh
	xor eax,eax
	add rsp,28h
	ret
	test r8,r8
	je short 00000001806B1429h
	cdqe
	mov rax,[r8+rax*8+20h]
	add rsp,28h
	ret
	call 00000001804FEE20h
	int 3
	call 00000001804FEE10h

ISIL:
	001 ShiftStack -40
	002 Compare [rcx+112], 45
	003 Move r8, [rcx+280]
	004 JumpIfEqual {12}
	005 Compare r8, 0
	006 JumpIfEqual {39}
	007 Compare [r8+24], 0
	008 JumpIfLessOrEqual {41}
	009 Move rax, [r8+32]
	010 ShiftStack 40
	011 Return rax
	012 Nop 
	013 Move rax, 0
	014 LoadAddress rdx, [r8+32]
	015 Move rcx, rax
	016 Compare r8, 0
	017 JumpIfEqual {39}
	018 Compare rax, [r8+24]
	019 JumpIfGreaterOrEqual {41}
	020 Move r9, [rdx]
	021 Compare r9, 0
	022 JumpIfEqual {39}
	023 Compare [r9+32], 0
	024 JumpIfEqual {33}
	025 Add rax, rax, 1
	026 Add rcx, rcx, 1
	027 Add rdx, rdx, 8
	028 Compare rcx, 5
	029 JumpIfLess {18}
	030 Move rax, 0
	031 ShiftStack 40
	032 Return rax
	033 Compare r8, 0
	034 JumpIfEqual {39}
	035 Move rax, rax
	036 Move rax, [r8+32+rax*8]
	037 ShiftStack 40
	038 Return rax
	039 Call 0x1804FEE20, rcx, rdx, r8, r9
	040 Interrupt 
	041 Call 0x1804FEE10, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
