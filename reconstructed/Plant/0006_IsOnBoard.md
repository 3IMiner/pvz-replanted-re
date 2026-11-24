# System.Boolean IsOnBoard()

- 类：`Plant`
- 汇编行数：17

## 反汇编

```asm

Disassembly:
	cmp qword ptr [rcx+18h],0
	je short 00000001806B227Fh
	movzx eax,byte ptr [rcx+137h]
	ret
	xor al,al
	ret

ISIL:
	001 Compare [rcx+24], 0
	002 JumpIfEqual {5}
	003 Move rax, [rcx+311]
	004 Return rax
	005 Move rax, 0
	006 Return rax
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
