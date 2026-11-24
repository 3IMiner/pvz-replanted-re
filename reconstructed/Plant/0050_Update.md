# System.Void Update()

- 类：`Plant`
- 汇编行数：163

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,20h
	cmp qword ptr [rcx+18h],0
	mov rbx,rcx
	je short 00000001806BE1EDh
	cmp byte ptr [rcx+137h],0
	je short 00000001806BE1EDh
	mov rax,[rcx+10h]
	test rax,rax
	je near ptr 00000001806BE2C0h
	cmp dword ptr [rax+0E0h],2
	jne short 00000001806BE1EDh
	xor edx,edx
	mov rcx,rax
	call 00000001807DFA20h
	test al,al
	jne short 00000001806BE267h
	cmp qword ptr [rbx+18h],0
	je short 00000001806BE267h
	cmp byte ptr [rbx+137h],0
	je short 00000001806BE216h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806BE2C0h
	xor edx,edx
	call 00000001807E3010h
	cmp eax,2Bh
	je short 00000001806BE267h
	cmp qword ptr [rbx+18h],0
	je short 00000001806BE267h
	cmp byte ptr [rbx+137h],0
	je short 00000001806BE245h
	mov rax,[rbx+18h]
	mov rcx,[rax+108h]
	test rcx,rcx
	je near ptr 00000001806BE2C0h
	xor edx,edx
	call 00000001806A5B20h
	test al,al
	jne short 00000001806BE267h
	cmp qword ptr [rbx+18h],0
	je short 00000001806BE267h
	cmp byte ptr [rbx+137h],0
	je short 00000001806BE267h
	mov rax,[rbx+10h]
	test rax,rax
	je short 00000001806BE2C0h
	cmp dword ptr [rax+0E0h],3
	jne short 00000001806BE2BAh
	xor edx,edx
	mov rcx,rbx
	call 00000001806B6170h
	xor edx,edx
	mov rcx,rbx
	call 00000001806AB9B0h
	cmp dword ptr [rbx+8Ch],0
	jge short 00000001806BE28Eh
	xor edx,edx
	mov rcx,rbx
	call 00000001806ACD40h
	xor edx,edx
	mov rcx,rbx
	call 00000001806BB7F0h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806BE2C0h
	xor edx,edx
	call 00000001807C8A50h
	xor edx,edx
	mov rcx,rbx
	add rsp,20h
	pop rbx
	jmp near ptr 00000001806AEDE0h
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
	006 JumpIfEqual {19}
	007 Compare [rcx+311], 0
	008 JumpIfEqual {19}
	009 Move rax, [rcx+16]
	010 Compare rax, 0
	011 JumpIfEqual {81}
	012 Compare [rax+224], 2
	013 JumpIfNotEqual {19}
	014 Move rdx, 0
	015 Move rcx, rax
	016 Call GameplayActivity.IsWallnutBowlingLevel, rcx, rdx
	017 Compare rax, 0
	018 JumpIfNotEqual {51}
	019 Compare [rbx+24], 0
	020 JumpIfEqual {51}
	021 Compare [rbx+311], 0
	022 JumpIfEqual {30}
	023 Move rcx, [rbx+16]
	024 Compare rcx, 0
	025 JumpIfEqual {81}
	026 Move rdx, 0
	027 Call GameplayActivity.get_GameMode, rcx, rdx
	028 Compare rax, 43
	029 JumpIfEqual {51}
	030 Compare [rbx+24], 0
	031 JumpIfEqual {51}
	032 Compare [rbx+311], 0
	033 JumpIfEqual {42}
	034 Move rax, [rbx+24]
	035 Move rcx, [rax+264]
	036 Compare rcx, 0
	037 JumpIfEqual {81}
	038 Move rdx, 0
	039 Call CutScene.ShouldRunUpsellBoard, rcx, rdx
	040 Compare rax, 0
	041 JumpIfNotEqual {51}
	042 Compare [rbx+24], 0
	043 JumpIfEqual {51}
	044 Compare [rbx+311], 0
	045 JumpIfEqual {51}
	046 Move rax, [rbx+16]
	047 Compare rax, 0
	048 JumpIfEqual {81}
	049 Compare [rax+224], 3
	050 JumpIfNotEqual {77}
	051 Move rdx, 0
	052 Move rcx, rbx
	053 Call Plant.UpdateAbilities, rcx, rdx
	054 Move rdx, 0
	055 Move rcx, rbx
	056 Call Plant.Animate, rcx, rdx
	057 Compare [rbx+140], 0
	058 JumpIfGreaterOrEqual {62}
	059 Move rdx, 0
	060 Move rcx, rbx
	061 Call Plant.Die, rcx, rdx
	062 Move rdx, 0
	063 Move rcx, rbx
	064 Call Plant.UpdateReanim, rcx, rdx
	065 Move rcx, [rbx+320]
	066 Compare rcx, 0
	067 JumpIfEqual {81}
	068 Move rdx, 0
	069 Call ReloadedCharacterController.UpdateAnim, rcx, rdx
	070 Move rdx, 0
	071 Move rcx, rbx
	072 ShiftStack 32
	073 Move rbx, stack:0x0
	074 ShiftStack 8
	075 Call Plant.Draw, rcx, rdx
	076 Return 
	077 ShiftStack 32
	078 Move rbx, stack:0x0
	079 ShiftStack 8
	080 Return 
	081 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
