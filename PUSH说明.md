# 推送到 GitHub

仓库已 `git init` 并完成首个提交（`75991dd`），工作区干净。

## 1. 在 GitHub 建空仓库

网页 → New repository，名字例如 `pvz-replanted-re`，**不要**勾选 "Initialize with README"（本地已有）。

## 2. 关联并推送

把下面 `OWNER` / `REPO` 换成你自己的：

```bash
cd F:/PY/PVZREAPK/pvz-replanted-re
git remote add origin https://github.com/OWNER/REPO.git
git branch -M main
git push -u origin main
```

如果本机配过 GitHub 凭据（HTTPS 用 credential manager，或 SSH key），直接就能推。

## 3. 校验（已通过）

| 项 | 值 |
|---|---|
| 已跟踪文件 | 148 |
| blob 总大小 | 91.9 MB（GitHub 建议 < 1 GB，软提醒 5 GB） |
| 最大单文件 | 63.1 MB（`archives/isil.zip`，硬上限 100 MB） |
| 工作区 | 干净 |

## 4. 有意排除的内容

| 内容 | 原因 |
|---|---|
| `re/project/ExportedProject`（17 GB） | 含多个 >100 MB 单文件（最大 489 MB），超过 GitHub 硬限制；且是 AssetRipper 生成的工程骨架，可由工具重建 |
| `dist/*.apk`、游戏本体 exe/dll/bundle | 体积大且属游戏文件，不属逆向资料 |
| `archives/*/` 解压出来的散文件 | 已压缩成 zip，`.gitignore` 排除；用 `unzip` 还原即可 |
| 原始游戏安装目录 | 需自备正版 |

## 5. 大文件备选方案

若以后要收录 AssetRipper 工程（>100 MB 单文件），用 Git LFS：

```bash
git lfs install
git lfs track "*.bundle" "*.webm" "*.pak"
git add .gitattributes && git commit -m "track large game assets with LFS"
```

注意 LFS 免费额度 1 GB/月，17 GB 需付费或用 Release 附件分发。
