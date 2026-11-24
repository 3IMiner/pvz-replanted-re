# System.Boolean NotOnGround()

- 类：`Plant`
- 汇编行数：41

## 反汇编

```asm

Disassembly:
	cmp dword ptr [rcx+70h],11h
	jne short 00000001806B33A1h
	cmp dword ptr [rcx+88h],5
	je short 00000001806B33BCh
	cmp dword ptr [rcx+88h],6
	je short 00000001806B33BCh
	cmp dword ptr [rcx+88h],7
	je short 00000001806B33BCh
	cmp byte ptr [rcx+3Ch],0
	jne short 00000001806B33BCh
	cmp dword ptr [rcx+128h],2
	je short 00000001806B33BCh
	cmp byte ptr [rcx+135h],0
	jne short 00000001806B33BCh
	xor al,al
	ret
	mov al,1
	ret

ISIL:
	001 Compare [rcx+112], 17
	002 JumpIfNotEqual {9}
	003 Compare [rcx+136], 5
	004 JumpIfEqual {17}
	005 Compare [rcx+136], 6
	006 JumpIfEqual {17}
	007 Compare [rcx+136], 7
	008 JumpIfEqual {17}
	009 Compare [rcx+60], 0
	010 JumpIfNotEqual {17}
	011 Compare [rcx+296], 2
	012 JumpIfEqual {17}
	013 Compare [rcx+309], 0
	014 JumpIfNotEqual {17}
	015 Move rax, 0
	016 Return rax
	017 Move rax, 1
	018 Return rax
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
